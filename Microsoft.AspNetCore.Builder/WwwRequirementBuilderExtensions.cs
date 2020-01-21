using Microsoft.AspNetCore.Rewrite;
using System;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// Extension methods for the WwwRedirection middleware.
    /// </summary>
    public static class WwwRequirementBuilderExtensions
    {
        /// <summary>
        /// Adds middleware for redirecting with out WWW Requests to WWW.
        /// </summary>
        /// <param name="app">The <see cref="IApplicationBuilder"/> instance this method extends.</param>
        /// <returns>The <see cref="IApplicationBuilder"/> for WWWRedirection.</returns>
        public static IApplicationBuilder UseWwwRedirection(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            var options = new RewriteOptions();
            options.AddRedirectToWww();
            app.UseRewriter(options);
            return app;
        }
    }
}
