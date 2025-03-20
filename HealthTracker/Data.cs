using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final_112323153.HealthData;
using static Final_112323153.LogIn;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Final_112323153
{
    public static class GlobalForm
    {
        
        public static CreateUser createuserForm = new CreateUser();
        public static UserLogIn userloginForm = new UserLogIn();
        public static HealthTracker_1 healthtracker_1Form = new HealthTracker_1();
        public static HealthTracker_2 healthtracker_2Form = new HealthTracker_2();
        public static CaptuePicture capturepictureForm = new CaptuePicture();
    }


    public class LogIn
    {
        
        
        public string pattern = "^[a-zA-Z0-9]+$";
        public string filepath = "";
        private string UserfilePath = @"D:\Final_112323153\Final_112323153\Data\User.txt";
        private string NutritionistPath = @"D:\Final_112323153\Final_112323153\Data\Nutritionist.txt";
        public string UserId { get; set; }
        public VaildState State { get; set; }

        List<string> usernames = new List<string>();
        List<string> passwords = new List<string>();

        public LogIn()
        {
            UserId = string.Empty;  
        }
        public enum VaildState
        {
            VALID,
            INVALID
        }
        public virtual bool KeyProcess(object sender, KeyPressEventArgs e)
        {
            //字元判斷，只接受英文大小寫或者是!_/跟返回建
            if (!(Regex.IsMatch(e.KeyChar.ToString(), pattern) || e.KeyChar == (char)8))
            {
                return true;
            }
            return false;
        }
        private void Flag(out string filepath, bool flag)
        {
            filepath = flag ? NutritionistPath : UserfilePath;
        }
        public void Read(out List<string> usernamese, out List<string> password, bool flag)
        {

            Flag(out filepath, flag);

            usernamese = new List<string>();
            password = new List<string>();

            try
            {

                using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    if (lines.Length > 0)
                    {
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length == 2)
                            {
                                usernamese.Add(parts[0]);
                                password.Add(parts[1]);

                            }
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Failed to read the file " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public LogIn Validation(string inputUsername, string inputPassword, bool flag)
        {   
            LogIn result = new LogIn();

            try
            {
                
                Read(out usernames, out passwords, flag);

                int index = usernames.FindIndex(u => u.Equals(inputUsername, StringComparison.OrdinalIgnoreCase));
                if (index == -1)
                {
                    MessageBox.Show("Error: Incorrect User Name", "Incorrect User Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result.State = VaildState.INVALID;
                }
                else if (passwords[index].Equals(inputPassword, StringComparison.OrdinalIgnoreCase))
                {
                    result.UserId = inputUsername;
                    result.State = VaildState.VALID;
                }
                else
                {
                    MessageBox.Show("Error: Incorrect Password", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result.State = VaildState.INVALID;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to read the file: " + ex.Message, "Failed to read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result.State = VaildState.INVALID;
            }
            return result;
        }

        public void Save(string inputUsername, string inputPassword, bool flag)
        {
            try
            {
                Read(out usernames, out passwords, flag);
                Flag(out filepath, flag);
                int index = usernames.FindIndex(u => u.Equals(inputUsername, StringComparison.OrdinalIgnoreCase));
                if (index == -1)
                {
                    using (StreamWriter writer = new StreamWriter(filepath, true)) // true to append data to the file
                    {
                        writer.WriteLine($"\n{inputUsername}\t{inputPassword}"); // Write the username and password separated by a tab
                    }
                    MessageBox.Show("User saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Have Some User Name", "Incorrect User Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
    public class HealthData : LogIn, IAdviceService
    {
        public string Advice = "";
        private string _bloodSugar="";
        private string _heartRate = "";
        private string _bloodPressure = "";
        private string _cholesterol = "";
        private string _weight = "";
        public string HealthDataUserfilePath = "";
        //文字處理，此方法是防止讀取到的資料有不相干的文字
        public string BloodSugar
        {
            get { return _bloodSugar; }
            set
            {
                if (float.TryParse(value, out float numericValue) && (numericValue < 0 || numericValue > 300))
                {
                    MessageBox.Show("Blood Sugar must be between 0 and 300.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _bloodSugar = "";
                    return;
                }
                _bloodSugar = value;
                
            }
        }
        public string HeartRate
        {
            get { return _heartRate; }
            set 
            {
                if (float.TryParse(value, out float numericValue) && (numericValue < 0 || numericValue > 300))
                {
                    MessageBox.Show("Heart Rate must be between 0 and 300.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _heartRate = "";
                    return;
                }
                _heartRate = value;  
            } 
        }
        public string BloodPressure
        {
            get { return _bloodPressure; }
            set
            {
                value = validBloodPressure(value);
                _bloodPressure = value;
            }
        }
        public string Cholesterol
        {
            get { return _cholesterol; }
            set
            {
                if (float.TryParse(value, out float numericValue) && (numericValue < 0 || numericValue > 300))
                {
                    MessageBox.Show("Cholesterol Level must be between 0 and 300.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _cholesterol = "";
                    return;
                }
                _cholesterol = value;
            }
        }
        public string Weight
        {
            get { return _weight; }
            set
            {
                if (float.TryParse(value, out float numericValue) && (numericValue < 0 || numericValue > 200))
                {
                    MessageBox.Show("Weight must be between 0 and 200.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _weight = "";
                    return;
                }
                _weight = value;
            }
        }
        private string validBloodPressure(string input)
        {
            if (input.Count(f => f == '/') != 1)
            {
                MessageBox.Show("Formatting error: Please check the data format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            string[] parts = input.Split('/');
            if (!int.TryParse(parts[0], out int systolic) || !int.TryParse(parts[1], out int diastolic))
            {
                return "";
            }
            if (systolic < 50 || systolic >300|| systolic < 0 || diastolic > 200 ) 
            {
                MessageBox.Show("Blood Pressure input error.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
                

            return input;
        }
        public override bool KeyProcess(object sender, KeyPressEventArgs e)
        {
            //字元判斷，只接受英文大小寫或者是!_/跟返回鍵
            if (!(Regex.IsMatch(e.KeyChar.ToString(), pattern) ||
                   e.KeyChar == '.' || e.KeyChar == '/' || e.KeyChar == (char)8))
            {
                return true;
            }
            return false;   
        }
        

        private bool ValidateInput(string input, string pattern, string fieldName)
        {

            if (!Regex.IsMatch(input, pattern))
            {
                MessageBox.Show($"{fieldName} must contain only letters and numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public HealthData Load(string userID, bool flag)
        {
            //用於判斷式使用者還是營養師
            HealthData healthdata = new HealthData();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string userFilePath = $@"D:\Final_112323153\Final_112323153\Data\User\{userID}";
                string nfilePath = $@"D:\Final_112323153\Final_112323153\Data\User";

                openFileDialog.InitialDirectory = flag ? nfilePath : userFilePath;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    healthdata.HealthDataUserfilePath = openFileDialog.FileName;
                    healthdata.State = VaildState.VALID;
                }
                else
                {
                    healthdata.HealthDataUserfilePath = string.Empty;
                    healthdata.State = VaildState.INVALID;
                }
            }
            return healthdata;
        }

        public List<HealthData> ReadHealthdata(string filepath)
        {
            List<HealthData> healthInfo = new List<HealthData>();
            try
            {
                
                using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {

                    string[] lines = File.ReadAllLines(filepath);
                    
                    //string[] parts = line.Split(' '); 
                    if (lines.Length >= 4) 
                    {
                        HealthData healthData = new HealthData
                        {
                            BloodSugar = lines[0],   
                            HeartRate = lines[1],    
                            BloodPressure = lines[2], 
                            Cholesterol = lines[3],  
                            Weight = lines[4]        
                        };

                        healthInfo.Add(healthData);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to read the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return healthInfo;
        }
        public bool isAdvice(string filePath)
        {
            try
            {
                string fileName = Path.GetFileName(filePath.TrimEnd(Path.DirectorySeparatorChar));
                return fileName.Equals("Advice.txt", StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                MessageBox.Show("Failed to read the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string ReadAdvice(string filePath)
        {
            string advice = string.Empty;
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length > 0)
                    {
                        advice = lines[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to read the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return advice;
        }
        public VaildState isInputOK(string bs, string hr, string bp, string cl, string w)
        {
            string BPpattern = @"^\d+/\d+$";

            if (!ValidateInput(bs, pattern, "Blood Sugar"))
                return VaildState.INVALID;
            if (!ValidateInput(hr, pattern, "Heart Rate"))
                return VaildState.INVALID;
            if (!ValidateInput(bp, BPpattern, "Blood Pressure"))
                return VaildState.INVALID;
            if (!ValidateInput(cl, pattern, "Cholesterol Level"))
                return VaildState.INVALID;
            if (!ValidateInput(w, pattern, "Weight"))
                return VaildState.INVALID;

            return VaildState.VALID;
        }
        public string isDirectoryExcits(string userID, string date, string time)
        {
            //判斷路徑是否存在，若無則創建該路徑
            string userPath = $@"D:\Final_112323153\Final_112323153\Data\User\{userID}";
            string datePath = $@"{userPath}\{date}\";
            string directoryPath = $@"{datePath}\{time}";
            try
            {
                if (!Directory.Exists(userPath))
                {
                    Directory.CreateDirectory(userPath);
                }
                if (!Directory.Exists(datePath))
                {
                    Directory.CreateDirectory(datePath);
                }
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to creat the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return directoryPath;
        }


        public void SaveHealthData(string userID, string date, string time, string healthData)
        {
            //儲存輸入數據
            try
            {  
                // 建立文件名
                string fullFilePath = Path.Combine(isDirectoryExcits(userID, date, time), $"{time}.txt");

                // 寫入數據到文件
                File.WriteAllText(fullFilePath, healthData);

                MessageBox.Show("Health data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save the health data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SaveImage(Bitmap tempImage, string userID, string date, string time)
        {
            //儲存拍攝照片
            try
            {
                string fullFilePath = Path.Combine(isDirectoryExcits(userID, date, time), $"{time}.jpg");
                tempImage.Save(fullFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Image captured saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SaveAdvice(string filepath, string date, string time, string advice)
        {
            //儲存營養師建議
            try
            {
                string fullFilePath = Path.Combine(Path.GetDirectoryName(filepath)!, $"Advice.txt");
                File.WriteAllText(fullFilePath, advice);
                MessageBox.Show("Advice are saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to save the advice: " + "Please confirm whether the User data has been opened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
        
        public Image DisplayImage(string filePath)
        {
            Image image = new Bitmap(640, 480);
            try
            {
                image = Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return image;
        }
        public  Image ResizeImage(Image image, int width, int height)
        {
            //用於調整影像到小
            //參考來源:https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
            // 創建一個新的Bitmap對象
            Bitmap resizedImage = new Bitmap(width, height);

            // 創建Graphics對象進行繪圖操作
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                // 設置插值法以及讓換面變平滑
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                // 清除畫布並以透明顏色填充背景
                graphics.Clear(Color.Transparent);
                // 繪製圖像
                graphics.DrawImage(image, new Rectangle(0, 0, width, height));
            }

            return resizedImage;
        }

    }

    public interface IAdviceService
    {
        bool isAdvice(string filePath);
        string ReadAdvice(string filePath);
    }

}
