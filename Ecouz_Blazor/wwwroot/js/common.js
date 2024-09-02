function ShowConfirmationModal() {
    console.log("ShowConfirmationModal called");

    bootstrap.Modal.getOrCreateInstance(document.getElementById('bsConfirmationModal')).show();
}

function HideConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('bsConfirmationModal')).hide();
}