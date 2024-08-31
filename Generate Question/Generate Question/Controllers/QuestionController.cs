using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Generate_Question.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        public QuestionController()
        {
        }
        [HttpGet]
        public async Task<ActionResult> GenerateQuestion()
        {
            List<string> questionList = new List<string>()
            {
                "1. What is the difference between a compiled language and an interpreted language?",
                "2. Explain the concept of object-oriented programming (OOP).",
                "3. What is a RESTful API, and how does it differ from SOAP?",
                "4. Describe the OSI model and its layers.",
                "5. What is the purpose of a firewall in network security?",
                "6. What is cloud computing and its benefits?",
                "7. What is the difference between IaaS, PaaS, and SaaS?",
                "8. Explain the importance of database normalization.",
                "9. What are the differences between GET and POST requests in HTTP?",
                "10. What is version control, and why is it important?",
                "11. Describe the Agile software development methodology.",
                "12. What is the purpose of a proxy server?",
                "13. Explain the concept of load balancing.",
                "14. What is a DDoS attack, and how can it be mitigated?",
                "15. Describe the difference between a switch and a router.",
                "16. What is the role of a network administrator?",
                "17. Explain the concept of multi-tenancy in cloud environments.",
                "18. What are microservices, and how do they differ from monolithic applications?",
                "19. What is encryption, and what are the main types?",
                "20. Explain the significance of an SSL certificate.",
                "21. What are the main differences between SQL and NoSQL databases?",
                "22. What is a virtual private network (VPN), and how does it work?",
                "23. Describe the software development lifecycle (SDLC).",
                "24. What is DevOps, and how does it impact software development?",
                "25. What is machine learning, and how can it be applied in IT?",
                "26. Explain the difference between asynchronous and synchronous programming.",
                "27. What is an API gateway, and what role does it play?",
                "28. Describe the Kimball and Inmon methodologies for data warehousing.",
                "29. What are some common cybersecurity threats and how can they be prevented?",
                "30. Explain what big data is and how it differs from traditional data processing.",
                "31. What is the role of a data scientist in an organization?",
                "32. Describe the principles of the Agile Manifesto.",
                "33. What is Kanban and how is it used in project management?",
                "34. Explain the difference between dynamic and static typing in programming languages.",
                "35. What are the benefits of using containers in software deployment?"
            };

            Random random = new Random();
            List<string> randomQuestions = questionList.OrderBy(q => random.Next()).Take(10).ToList();

            return Ok(randomQuestions);
        }
    }
}
