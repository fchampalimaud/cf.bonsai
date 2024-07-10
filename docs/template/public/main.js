import WorkflowContainer from "./workflow.js"

export default {
    start: () => {
        WorkflowContainer.init();
    }
}

const observer = new MutationObserver(() => {
    if (document.documentElement.getAttribute("data-bs-theme") == "dark") {
      document.getElementById("logo").src = "/images/logo_white.svg"
    } else {
      document.getElementById("logo").src = "/images/logo.svg"
    }
  });
  
  observer.observe(document.documentElement, {
    attributes: true,
    attributeFilter: ['data-bs-theme'] // only observe changes to this specific attribute
  });