import React, { Component } from 'react';
import { LeadInvited } from './LeadInvited'

export class InvitedTab extends Component {

    constructor(props) {
        super(props);
        this.state = {
            leads: [],
            loading: true
        };
    }

    componentDidMount() {
        this.populateLeadsData();
    }

    static renderInvitedTabs(leads) {
        return (
            leads.map(lead =>
                <LeadInvited
                    Name={lead.firstName}
                    CreateDate={lead.createDate}
                    Location={lead.location}
                    Category={lead.category}
                    JobDescription={lead.description}
                    JobId={lead.id}
                    Value={lead.price}
                />
            )
            );
    }

    render() {

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : InvitedTab.renderInvitedTabs(this.state.leads);

        return (
            <div>
                {contents}
            </div>
            );
    }

    async populateLeadsData() {
        const response = await fetch('api/leads/invited');
        const data = await response.json();
        this.setState({ leads: data, loading: false });
    }
}