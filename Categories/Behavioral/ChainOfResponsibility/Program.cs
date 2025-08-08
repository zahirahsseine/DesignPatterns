var chatbot = new ChatBotSupport();
var junior = new JuniorSupport();
var senior = new SeniorSupport();

chatbot.SetNext(junior);
junior.SetNext(senior);

var req1 = new SupportRequest("Password reset", "basic");
var req2 = new SupportRequest("App crash on login", "intermediate");
var req3 = new SupportRequest("Database corrupt", "advanced");

chatbot.Handle(req1);
chatbot.Handle(req2);
chatbot.Handle(req3);