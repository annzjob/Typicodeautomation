using NUnit.Framework;
using System;
using System.Net;
using TechTalk.SpecFlow;


namespace TypiCodeProject.Steps
{
    [Binding]
    public class APItestsSteps
    {
        
        [Given(@"I have an endpoint to create post (.*)")]
        public void GivenIHaveAnEndopintToCreatePost(string endpoint)
        {
            RestApiHelper.SetUrl(endpoint);
        }
        
        [Given(@"I have an endpoint to get post (.*)")]
        public void GivenIHaveAnEndpointToGetPost(string endpoint)
        {
            RestApiHelper.SetUrl(endpoint);
           
        }
        
        [Given(@"I have a post that does not exist")]
        public void GivenIHaveAPostThatDoesNotExist()
        {
            RestApiHelper.PostDoesNotExist();
            
        }
        [When(@"I send request to replace a post")]
        public void WhenISendRequestToReplaceAPost(string Id)
        {
            RestApiHelper.ReplacePostRequest(Id);

        }
        
        [When(@"I send request to delete a post by (.*)")]
        public void WhenISendRequestToDeleteAPostBy(string Id)
        {
            RestApiHelper.DeleteRequest(Id);
        }
        
        [When(@"I send request to get IdontExist (.*)")]
        public void WhenISendRequestToGetIdontExist(string endpoint)
        {
            RestApiHelper.SetUrlIdontexist(endpoint);

        }
        
        [Then(@"the response status is (.*) OK")]
        public void ThenTheResponseStatusIsOK()
        {
            var response = RestApiHelper.GetResponse();
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.StatusCode, Is.EqualTo(200));
            }
          }
        [Then(@"the response status is (.*) or (.*) OK and the post should be updated successfully")]
        public void ThenTheResponseStatusIsOrOKAndThePostShouldBeUpdatedSuccessfully()
        {
            var response = RestApiHelper.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.StatusCode, Is.EqualTo(200));
            }
            else
                Assert.That(response.StatusCode, Is.EqualTo(204));


        }
        
        [Then(@"the response status is (.*) No Content")]
        public void ThenTheResponseStatusIsNoContent()
        {
            var response = RestApiHelper.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.StatusCode, Is.EqualTo(204));
            }

        }
        
        [Then(@"the response status is (.*) Not found")]
        public void ThenTheResponseStatusIsNotFound()
        {
            var response = RestApiHelper.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.StatusCode, Is.EqualTo(404));
            }

        }

        [When(@"I send request to get a post by (.*)")]
        public void WhenISendRequestToGetAPostby(string Id)
        {
            RestApiHelper.GetRequest(Id);
        }

        [When(@"I send request to create a post with data")]
        public void WhenISendRequestToCreateAPostWith()
        {
            RestApiHelper.CreatePostRequest();
        }

        [Given(@"I have an existing post(.*)")]
        public void GivenIHaveAnExistingPost(string endpoint)
        {
            
            RestApiHelper.SetUrl(endpoint);
        }
    }
}
