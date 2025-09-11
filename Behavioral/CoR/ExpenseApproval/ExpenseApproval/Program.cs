
var levelOneSupport = new LevelOneSupport();
var levelTwoSupport = new LevelTwoSupport();

levelOneSupport.SetNextSupportLevel(levelTwoSupport);
levelTwoSupport.SetNextSupportLevel(new NullHandler());

levelOneSupport.HandleSupportRequest(RequestType.ConfigurationIssue);

levelOneSupport.HandleSupportRequest(RequestType.BugFix);

