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
    public class GetResourceConfigurationTimelineResponseUnmarshaller
    {
        public static GetResourceConfigurationTimelineResponse Unmarshall(UnmarshallerContext context)
        {
			GetResourceConfigurationTimelineResponse getResourceConfigurationTimelineResponse = new GetResourceConfigurationTimelineResponse();

			getResourceConfigurationTimelineResponse.HttpResponse = context.HttpResponse;
			getResourceConfigurationTimelineResponse.RequestId = context.StringValue("GetResourceConfigurationTimeline.RequestId");

			GetResourceConfigurationTimelineResponse.GetResourceConfigurationTimeline_ResourceConfigurationTimeline resourceConfigurationTimeline = new GetResourceConfigurationTimelineResponse.GetResourceConfigurationTimeline_ResourceConfigurationTimeline();
			resourceConfigurationTimeline.NextToken = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.NextToken");
			resourceConfigurationTimeline.Limit = context.IntegerValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.Limit");
			resourceConfigurationTimeline.TotalCount = context.LongValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.TotalCount");

			List<GetResourceConfigurationTimelineResponse.GetResourceConfigurationTimeline_ResourceConfigurationTimeline.GetResourceConfigurationTimeline_ConfigurationListItem> resourceConfigurationTimeline_configurationList = new List<GetResourceConfigurationTimelineResponse.GetResourceConfigurationTimeline_ResourceConfigurationTimeline.GetResourceConfigurationTimeline_ConfigurationListItem>();
			for (int i = 0; i < context.Length("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList.Length"); i++) {
				GetResourceConfigurationTimelineResponse.GetResourceConfigurationTimeline_ResourceConfigurationTimeline.GetResourceConfigurationTimeline_ConfigurationListItem configurationListItem = new GetResourceConfigurationTimelineResponse.GetResourceConfigurationTimeline_ResourceConfigurationTimeline.GetResourceConfigurationTimeline_ConfigurationListItem();
				configurationListItem.AccountId = context.LongValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].AccountId");
				configurationListItem.AvailabilityZone = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].AvailabilityZone");
				configurationListItem.CaptureTime = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].CaptureTime");
				configurationListItem.ConfigurationDiff = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].ConfigurationDiff");
				configurationListItem.Region = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].Region");
				configurationListItem.Relationship = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].Relationship");
				configurationListItem.RelationshipDiff = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].RelationshipDiff");
				configurationListItem.ResourceCreateTime = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].ResourceCreateTime");
				configurationListItem.ResourceId = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].ResourceId");
				configurationListItem.ResourceName = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].ResourceName");
				configurationListItem.ResourceType = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].ResourceType");
				configurationListItem.Tags = context.StringValue("GetResourceConfigurationTimeline.ResourceConfigurationTimeline.ConfigurationList["+ i +"].Tags");

				resourceConfigurationTimeline_configurationList.Add(configurationListItem);
			}
			resourceConfigurationTimeline.ConfigurationList = resourceConfigurationTimeline_configurationList;
			getResourceConfigurationTimelineResponse.ResourceConfigurationTimeline = resourceConfigurationTimeline;
        
			return getResourceConfigurationTimelineResponse;
        }
    }
}
