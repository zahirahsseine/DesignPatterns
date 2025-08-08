var emailService = new EmailService();
var notification = new Notification(emailService);
notification.Send("Hello World!");