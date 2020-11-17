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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class GetResourceComplianceTimelineResponseUnmarshaller
    {
        public static GetResourceComplianceTimelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResourceComplianceTimelineResponse getResourceComplianceTimelineResponse = new GetResourceComplianceTimelineResponse();

			getResourceComplianceTimelineResponse.HttpResponse = _ctx.HttpResponse;
			getResourceComplianceTimelineResponse.RequestId = _ctx.StringValue("GetResourceComplianceTimeline.RequestId");

			GetResourceComplianceTimelineResponse.GetResourceComplianceTimeline_ResourceComplianceTimeline resourceComplianceTimeline = new GetResourceComplianceTimelineResponse.GetResourceComplianceTimeline_ResourceComplianceTimeline();
			resourceComplianceTimeline.Limit = _ctx.IntegerValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.Limit");
			resourceComplianceTimeline.TotalCount = _ctx.LongValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.TotalCount");
			resourceComplianceTimeline.NextToken = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.NextToken");

			List<GetResourceComplianceTimelineResponse.GetResourceComplianceTimeline_ResourceComplianceTimeline.GetResourceComplianceTimeline_ComplianceListItem> resourceComplianceTimeline_complianceList = new List<GetResourceComplianceTimelineResponse.GetResourceComplianceTimeline_ResourceComplianceTimeline.GetResourceComplianceTimeline_ComplianceListItem>();
			for (int i = 0; i < _ctx.Length("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList.Length"); i++) {
				GetResourceComplianceTimelineResponse.GetResourceComplianceTimeline_ResourceComplianceTimeline.GetResourceComplianceTimeline_ComplianceListItem complianceListItem = new GetResourceComplianceTimelineResponse.GetResourceComplianceTimeline_ResourceComplianceTimeline.GetResourceComplianceTimeline_ComplianceListItem();
				complianceListItem.AccountId = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].AccountId");
				complianceListItem.AvailabilityZone = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].AvailabilityZone");
				complianceListItem.CaptureTime = _ctx.LongValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].CaptureTime");
				complianceListItem.Configuration = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].Configuration");
				complianceListItem.ConfigurationDiff = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].ConfigurationDiff");
				complianceListItem.Region = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].Region");
				complianceListItem.ResourceCreateTime = _ctx.LongValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].ResourceCreateTime");
				complianceListItem.ResourceId = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].ResourceId");
				complianceListItem.ResourceName = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].ResourceName");
				complianceListItem.ResourceStatus = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].ResourceStatus");
				complianceListItem.ResourceType = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].ResourceType");
				complianceListItem.Tags = _ctx.StringValue("GetResourceComplianceTimeline.ResourceComplianceTimeline.ComplianceList["+ i +"].Tags");

				resourceComplianceTimeline_complianceList.Add(complianceListItem);
			}
			resourceComplianceTimeline.ComplianceList = resourceComplianceTimeline_complianceList;
			getResourceComplianceTimelineResponse.ResourceComplianceTimeline = resourceComplianceTimeline;
        
			return getResourceComplianceTimelineResponse;
        }
    }
}
