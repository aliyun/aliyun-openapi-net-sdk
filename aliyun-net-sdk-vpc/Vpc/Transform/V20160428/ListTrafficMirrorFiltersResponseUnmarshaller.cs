/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListTrafficMirrorFiltersResponseUnmarshaller
    {
        public static ListTrafficMirrorFiltersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTrafficMirrorFiltersResponse listTrafficMirrorFiltersResponse = new ListTrafficMirrorFiltersResponse();

			listTrafficMirrorFiltersResponse.HttpResponse = _ctx.HttpResponse;
			listTrafficMirrorFiltersResponse.NextToken = _ctx.StringValue("ListTrafficMirrorFilters.NextToken");
			listTrafficMirrorFiltersResponse.RequestId = _ctx.StringValue("ListTrafficMirrorFilters.RequestId");
			listTrafficMirrorFiltersResponse.TotalCount = _ctx.StringValue("ListTrafficMirrorFilters.TotalCount");

			List<ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter> listTrafficMirrorFiltersResponse_trafficMirrorFilters = new List<ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter>();
			for (int i = 0; i < _ctx.Length("ListTrafficMirrorFilters.TrafficMirrorFilters.Length"); i++) {
				ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter trafficMirrorFilter = new ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter();
				trafficMirrorFilter.TrafficMirrorFilterStatus = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].TrafficMirrorFilterStatus");
				trafficMirrorFilter.TrafficMirrorFilterDescription = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].TrafficMirrorFilterDescription");
				trafficMirrorFilter.TrafficMirrorFilterId = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].TrafficMirrorFilterId");
				trafficMirrorFilter.TrafficMirrorFilterName = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].TrafficMirrorFilterName");

				List<ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter.ListTrafficMirrorFilters_TrafficMirrorRule> trafficMirrorFilter_ingressRules = new List<ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter.ListTrafficMirrorFilters_TrafficMirrorRule>();
				for (int j = 0; j < _ctx.Length("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules.Length"); j++) {
					ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter.ListTrafficMirrorFilters_TrafficMirrorRule trafficMirrorRule = new ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter.ListTrafficMirrorFilters_TrafficMirrorRule();
					trafficMirrorRule.TrafficMirrorFilterRuleStatus = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].TrafficMirrorFilterRuleStatus");
					trafficMirrorRule.Action = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].Action");
					trafficMirrorRule.SourceCidrBlock = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].SourceCidrBlock");
					trafficMirrorRule.TrafficDirection = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].TrafficDirection");
					trafficMirrorRule.Protocol = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].Protocol");
					trafficMirrorRule.DestinationPortRange = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].DestinationPortRange");
					trafficMirrorRule.TrafficMirrorFilterRuleId = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].TrafficMirrorFilterRuleId");
					trafficMirrorRule.DestinationCidrBlock = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].DestinationCidrBlock");
					trafficMirrorRule.Priority = _ctx.IntegerValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].Priority");
					trafficMirrorRule.TrafficMirrorFilterId = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].TrafficMirrorFilterId");
					trafficMirrorRule.SourcePortRange = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].IngressRules["+ j +"].SourcePortRange");

					trafficMirrorFilter_ingressRules.Add(trafficMirrorRule);
				}
				trafficMirrorFilter.IngressRules = trafficMirrorFilter_ingressRules;

				List<ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter.ListTrafficMirrorFilters_TrafficMirrorRule> trafficMirrorFilter_egressRules = new List<ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter.ListTrafficMirrorFilters_TrafficMirrorRule>();
				for (int j = 0; j < _ctx.Length("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules.Length"); j++) {
					ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter.ListTrafficMirrorFilters_TrafficMirrorRule trafficMirrorRule = new ListTrafficMirrorFiltersResponse.ListTrafficMirrorFilters_TrafficMirrorFilter.ListTrafficMirrorFilters_TrafficMirrorRule();
					trafficMirrorRule.TrafficMirrorFilterRuleStatus = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].TrafficMirrorFilterRuleStatus");
					trafficMirrorRule.Action = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].Action");
					trafficMirrorRule.SourceCidrBlock = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].SourceCidrBlock");
					trafficMirrorRule.TrafficDirection = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].TrafficDirection");
					trafficMirrorRule.Protocol = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].Protocol");
					trafficMirrorRule.DestinationPortRange = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].DestinationPortRange");
					trafficMirrorRule.TrafficMirrorFilterRuleId = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].TrafficMirrorFilterRuleId");
					trafficMirrorRule.DestinationCidrBlock = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].DestinationCidrBlock");
					trafficMirrorRule.Priority = _ctx.IntegerValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].Priority");
					trafficMirrorRule.TrafficMirrorFilterId = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].TrafficMirrorFilterId");
					trafficMirrorRule.SourcePortRange = _ctx.StringValue("ListTrafficMirrorFilters.TrafficMirrorFilters["+ i +"].EgressRules["+ j +"].SourcePortRange");

					trafficMirrorFilter_egressRules.Add(trafficMirrorRule);
				}
				trafficMirrorFilter.EgressRules = trafficMirrorFilter_egressRules;

				listTrafficMirrorFiltersResponse_trafficMirrorFilters.Add(trafficMirrorFilter);
			}
			listTrafficMirrorFiltersResponse.TrafficMirrorFilters = listTrafficMirrorFiltersResponse_trafficMirrorFilters;
        
			return listTrafficMirrorFiltersResponse;
        }
    }
}
