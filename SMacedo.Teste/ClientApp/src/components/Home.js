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
            <div className="row rounded shadow border-5 border-dark">
                <div
                    onClick={this.handlerTabInvited}
                    className={this.state.activeTab === "invited" ? "col active text-center" : "col text-center"}>
                    Invited
                </div>
                <div
                    onClick={this.handlerTabAccepeted}
                    className={this.state.activeTab === "accepted" ? "col active text-center" : "col text-center"}>
                    Accepted
                </div>
            </div>
            {this.state.activeTab === "invited" ? <InvitedTab /> : <AcceptedTab />}
        </div>
    );
  }
}
