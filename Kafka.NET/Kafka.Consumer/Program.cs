using Kafka.Consumer.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IHostedService, KafkaConsumerHandler>();

var app = builder.Build();

app.Run();
