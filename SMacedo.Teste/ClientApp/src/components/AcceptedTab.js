import React, { Component } from 'react';
import { LeadAccepted } from './LeadAccepted'

export class AcceptedTab extends Component {

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

    static renderAcceptedTabs(leads) {
        return (
            leads.map(lead =>
                <LeadAccepted
                    Name={lead.firstName}
                    CreateDate={lead.createDate}
                    Location={lead.location}
                    Category={lead.category}
                    JobDescription={lead.description}
                    JobId={lead.id}
                    Value={lead.price}
                    Phone={lead.phone}
                    Email={lead.email}
                />
            )
        );
    }

    render() {

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : AcceptedTab.renderAcceptedTabs(this.state.leads);

        return (
            <div>
                {contents}
            </div>
        );
    }

    async populateLeadsData() {
        const response = await fetch('api/leads/accepted');
        const data = await response.json();
        this.setState({ leads: data, loading: false });
    }
}