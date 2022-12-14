namespace ApiCatalogo.AppServicesExtensions
{
    public static class ApplicationBuiderExtensions
    {
        public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder app,
            IWebHostEnvironment environment)
        {
            if(environment.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            return app;
        }

        public static IApplicationBuilder UseAppCors(this IApplicationBuilder app)
        {
            app.UseCors(p => {
                p.AllowAnyOrigin(); // politica que vai receber requisição de qualquer origem
                p.WithMethods("GET");// somente get
                p.AllowAnyHeader(); // com qualqualquer cabeçalho.
            });
            return app;
        }

        public static IApplicationBuilder UseSwaggerMiddleware(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => { });
            return app;
        }
    }
}
