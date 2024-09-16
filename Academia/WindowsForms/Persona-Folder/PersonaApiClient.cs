﻿using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using WindowsForms.Shared;

namespace WindowsForms
{
    public class PersonaApiClient
    {
        private static HttpClient client = new HttpClient();
        public static async Task<Persona> GetAsync(int id)
        {
            Persona persona = null;
            HttpResponseMessage response = await client.GetAsync("personas/" + id);
            if (response.IsSuccessStatusCode)
            {
                persona = await response.Content.ReadAsAsync<Persona>();
            }
            return persona;
        }

        public static async Task<IEnumerable<Persona>> GetAllAsync()
        {
            IEnumerable<Persona> personas = null;
            HttpResponseMessage response = await client.GetAsync("personas");
            if (response.IsSuccessStatusCode)
            {
                personas = await response.Content.ReadAsAsync<IEnumerable<Persona>>();
            }
            return personas;
        }

        public static async Task AddAsync(Persona persona)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("personas", persona);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("personas/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Persona persona)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("personas", persona);
            response.EnsureSuccessStatusCode();
        }
    }
