Contributing to The Image framework

The foundation of the Image framework is simplicity. A developer should be able to quickly and easily learn to use the API.

Simplicity and a low barrier to entry are must-have features of every API. If you have any second thoughts about the complexity of a design, it is almost always much better to cut the feature from the current release and spend more time to get the design right for the next release.
You can always add to an API, you cannot ever remove anything from one. If the design does not feel right, and you ship it anyway, you are likely to regret having done so.
That's why many of the guidelines of this document are obvious and serve only one purpose: Simplicity.

Found a Bug?
If you find a bug, you can help us by submitting an issue. Even better, you can submit a Pull Request with a fix.

Submitting a pull request

For every contribution, you must:
test your code with the supported SDKs
follow the quality guidance, general rules and naming convention
target master branch (or an appropriate release branch if appropriate for a bug fix)

If adding a new feature
Add or update unit tests (if applicable)

Adding Documentation
Documentation is required when adding, removing, or updating a control or an API. You can do the documentation in comments before the methods you added/edited

General rules
DO NOT require that users perform any extensive initialization before they can start programming basic scenarios.
DO provide good defaults for all values associated with parameters, options, etc.
DO ensure that APIs are intuitive and can be successfully used in basic scenarios without referring to the reference documentation.
DO communicate incorrect usage of APIs as soon as possible.
DO NOT use regions. DO use partial classes instead.
DO declare static dependency properties at the top of their file.
DO use extension methods over static methods where possible.
DO NOT return true or false to give success status. Throw exceptions if there was a failure.
DO use verbs like GET.
DO NOT use verbs that are not already used like fetch.

Naming conventions
We are following the coding guidelines of .NET Core Foundational libraries.

Documentation
DO NOT expect that your API is so well designed that it needs no documentation. No API is that intuitive.
DO provide great documentation with all APIs.
DO use readable and self-documenting identifier names.
DO use consistent naming and terminology.
DO provide strongly typed APIs.
DO use verbose identifier names.

Files and folders
DO associate no more than one class per file.
DO use folders to group classes based on features.
