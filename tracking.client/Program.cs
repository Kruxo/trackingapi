﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using tracking.client;

HttpClient client = new();
client.BaseAddress = new Uri("http://localhost:5210");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

HttpResponseMessage response = await client.GetAsync("api/issue");
response.EnsureSuccessStatusCode();

if (response.IsSuccessStatusCode)
{
    var issues = await response.Content.ReadFromJsonAsync<IEnumerable<IssueDto>>();
    foreach (var issue in issues)
    {
        Console.WriteLine(issue.Title);
    }
}

else
{
    Console.WriteLine("No Results");
}

Console.ReadLine();