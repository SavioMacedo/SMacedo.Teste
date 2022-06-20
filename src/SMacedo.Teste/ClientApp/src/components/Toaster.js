import React, { Component } from 'react';
import { Toast } from 'bootstrap/dist/js/bootstrap.esm'

export class Toaster extends Component {
    static showSuccess(message) {
        const toastbody = document.getElementById("liveSuccessMessage");
        toastbody.innerText = message;
        const toastLiveExample = document.getElementById('toastSuccess');
        const toast = new Toast(toastLiveExample);
        toast.show();
    }

    static showError(message) {
        const toastbody = document.getElementById("liveSuccessError");
        toastbody.innerText = message;
        const toastLiveExample = document.getElementById('toastError');
        const toast = new Toast(toastLiveExample);
        toast.show();
    }
}