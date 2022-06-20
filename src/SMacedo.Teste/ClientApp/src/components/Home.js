import React, { Component } from 'react';
import { InvitedTab } from './InvitedTab'
import { AcceptedTab } from './AcceptedTab'

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            activeTab: "invited"
        };
        this.handlerTabAccepeted = this.handlerTabAccepeted.bind(this);
        this.handlerTabInvited = this.handlerTabInvited.bind(this);
    }

    handlerTabInvited() {
        this.setState({
            activeTab: "invited"
        });
    }

    handlerTabAccepeted() {
        this.setState({
            activeTab: "accepted"
        });
    }

    render() {

    return (
        <div className="container-sm w-50">
            <div className="position-fixed top-20 start-50 translate-middle-x">
                <div id="toastSuccess" className="toast align-items-center text-white bg-success border-0" role="alert" aria-live="assertive" aria-atomic="true">
                    <div className="d-flex">
                        <div className="toast-body" id="liveSuccessMessage">
                            Hello, world! This is a toast message.
                        </div>
                        <button type="button" className="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                </div>
            </div>
            <div className="position-fixed top-20 start-50 translate-middle-x">
                <div id="toastError" className="toast align-items-center text-white bg-danger border-0" role="alert" aria-live="assertive" aria-atomic="true">
                    <div className="d-flex">
                        <div className="toast-body" id="liveSuccessError">
                            Hello, world! This is a toast message.
                        </div>
                        <button type="button" className="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                </div>
            </div>
            <div className="row rounded shadow border-5 border-dark">
                <div
                    onClick={this.handlerTabInvited}
                    className={this.state.activeTab === "invited" ? "col active text-center tab" : "col text-center tab"}>
                    Invited
                </div>
                <div
                    onClick={this.handlerTabAccepeted}
                    className={this.state.activeTab === "accepted" ? "col active text-center tab" : "col text-center tab"}>
                    Accepted
                </div>
            </div>
            {this.state.activeTab === "invited" ? <InvitedTab /> : <AcceptedTab />}
        </div>
    );
  }
}
