﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace frontend.Properties
{
    public class ResultSubmit
    {
        public string checking { get; set; }
        public string id { get; set; }
    }
    public class DataUser
    {
        public string ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
    public class DataStudent : DataUser
    {
        public string Class { get; set; }
     
    }
    public class DataTeacher : DataUser
    {
        public string LabRoom { get; set; }

    }
    public class Project
    {
        public int ID { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int numStudent { get; set; }
    }
    public class Project_Student
    {
        public int IDstudent { get; set; }
        public int IDproject { get; set; }
    }
    public class Project_Teacher
    {
        public int ID { get; set; }
        public int teacherId { get; set; }
        public int projectId { get; set; }
    }
    public class Data
    {
        public string id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }

    }
    public class Supp
    {
        public string url { get; set; }
        public string text { get; set; }
    }

 
    public static class RestHelper
    {
        private static readonly string baseURL = "http://localhost:3000/api/v1/";
        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }


        public static async Task<string> Post(string name, string job)
        {
            var inputData = new Dictionary<string, string>
            {
                {"name",name },
                {"job",job }
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "users", input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Put(string id)
        {
            ////var inputData = new Dictionary<string, string>
            ////{
            ////    {"name",name },
            ////    {"job",job }
            ////};
            ////string[] dirArray = new string[2];
            ////Create List of KeyValuePairs
            //List<KeyValuePair<string, string>> bodyProperties = new List<KeyValuePair<string, string>>();

            ////Add 'single' parameters
            //bodyProperties.Add(new KeyValuePair<string, string>("email", "kien"));
            //bodyProperties.Add(new KeyValuePair<string, string>("password", "1"));

            ////Loop over String array and add all instances to our bodyPoperties
            //foreach (var dir in dirArray)
            //{
            //    bodyProperties.Add(new KeyValuePair<string, string>("dirs[]", dir));
            //}

            ////convert your bodyProperties to an object of FormUrlEncodedContent
            //var dataContent = new FormUrlEncodedContent(bodyProperties.ToArray());

            ////var serializedParam = JsonConvert.SerializeObject(dirArray);
            ////var dataSend = new StringContent(serializedParam, Encoding.UTF8, "application/json");



            //using (HttpClient client = new HttpClient())
            //{
            //    using (HttpResponseMessage res = await client.PostAsync(baseURL + "users" + id, dataContent))
            //    {
            //        using (HttpContent content = res.Content)
            //        {
            //            string data = await content.ReadAsStringAsync();
            //            if (data != null)
            //            {
            //                return data;
            //            }
            //        }
            //    }
            //}
            //return string.Empty;
            using (HttpClient client = new HttpClient())
            {
                string[] param = new string[] { "A", "B", "C" };//test data
                string URI = baseURL + "users/login/"+id;
                var serializedParam = JsonConvert.SerializeObject(param);
                var content = new StringContent(serializedParam, Encoding.UTF8, "application/json");
                var result = client.PostAsync(URI, content).Result;
                return result.ToString();
            }
                
        }

                                                        //LOGIN
        public static async Task<string> Submit(string username, string password, string role)
        {

            var inputData = new Dictionary<string, string>
            {
                {"username", username },
                {"password", password },
                {"role",role }
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "users/login/", input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
                                        
                                                        //STUDENT
        //GET INFO STUDENT
        public static async Task<string> GetInfoSV(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "students/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        //EDIT INFO STUDENT
        public static async Task<string> EditInfoSV(string id, string phone, string email, string address)
        {
            var inputData = new Dictionary<string, string>
            {
                {"phone",phone },
                {"email",email },
                {"address", address }
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseURL + "users/" + id, input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
                                                    //teacher
        //GET INFO TEACHER
        public static async Task<string> GetInfoGV(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "teachers/get/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        // POST PROJECT

        public static async Task<string> PostProject(Project[] prj)
        {

            var json = JsonConvert.SerializeObject(prj);

            //byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //var input = new FormUrlEncodedContent(json);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "projectAsgns/createProject/", stringContent))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        // GET ALL TEACHER NAME

        public static async Task<string> GetNameGV()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "teachers/getAll" ))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        // GET PROJECT OF TEACHER

        public static async Task<string> GetProjectTeacher(int id, string type,bool teacher_table)
        {
            string base1_url;
            if (teacher_table)  base1_url = "projectAsgns/byid/";
            else  base1_url = "projectAsgns/";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + base1_url + type + "/" + id.ToString()))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        //STUDENT ASSIGN PROJECT
        public static async Task<string> student_assign_project(Project_Student[] prj)
        {

            var json = JsonConvert.SerializeObject(prj);

            //byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //var input = new FormUrlEncodedContent(json);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "projectAsgns/student/", stringContent))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        // GET PROJECT OF STUDENT
        public static async Task<string> GetProjectStudent(string id, string type)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL+ "projectAsgns/byidStudent/" + type + "/"+id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        // GET ALL PROJECT
        public static async Task<string> GetAllProject()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "projectAsgns/getAll"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        // GET TEACHER FROM PROJECT
        public static async Task<string> GetTeacherFromProject(string idProject)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "teachers/getTeacherbyProject/"+idProject))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        // GET STUDENT FROM PROJECT
        public static async Task<string> GetStudentFromProject(string idProject)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "students/getStudentbyProject/" + idProject))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

    }
}
