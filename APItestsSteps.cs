using System;
using TechTalk.SpecFlow;


namespace TypiCodeProject.Steps
{
    [Binding]
    public class APItestsSteps
    {
        
        [Given(@"I have an endpoint to create post")]
        public void GivenIHaveAnEndopintToCreatePost()
        {
            
        }
        
        [Given(@"I have an existing post")]
        public void GivenIHaveAnExistingPost()
        {
           
        }
        
        [Given(@"I have a post that does not exist")]
        public void GivenIHaveAPostThatDoesNotExist()
        {
            
        }
        
        
        
        [When(@"I send request to replace a post")]
        public void WhenISendRequestToReplaceAPost()
        {
            
        }
        
        [When(@"I send request to delete a post")]
        public void WhenISendRequestToDeleteAPost()
        {
           
        }
        
        [When(@"I send request to get IdontExist")]
        public void WhenISendRequestToGetIdontExist()
        {
            
        }
        
        [Then(@"the response status is (.*) OK and the response body should contain the Id")]
        public void ThenTheResponseStatusIsOKAndTheResponseBodyShouldContainTheId(int p0)
        {
            
        }
        
        [Then(@"the response status is (.*) or (.*) OK and the post should be updated successfully")]
        public void ThenTheResponseStatusIsOrOKAndThePostShouldBeUpdatedSuccessfully(int p0, int p1)
        {
            
        }
        
        [Then(@"the response status is (.*) No Content")]
        public void ThenTheResponseStatusIsNoContent(int p0)
        {
            
        }
        
        [Then(@"the response status is (.*) Not found")]
        public void ThenTheResponseStatusIsNotFound(int p0)
        {
            
        }

        [When(@"I send request to get a post")]
        public void WhenISendRequestToGetAPost()
        {
           
        }

        [When(@"I send request to create a post with\((.*),(.*),(.*),(.*)\)")]
        public void WhenISendRequestToCreateAPostWith(string Id, string Title, string Body, string UserId)
        {
        }

    }
}
