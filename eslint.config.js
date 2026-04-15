import js from "@eslint/js";

export default [
  js.configs.recommended,
  {
    languageOptions: {
      globals: {
        window: "readonly",
        document: "readonly",
        setTimeout: "readonly",
        requestAnimationFrame: "readonly"
      }
    },
    rules: {
      "no-var": "error",
      "eqeqeq": "error",
      "semi": ["error", "always"],
      "quotes": ["error", "double"]
    }
  }
];