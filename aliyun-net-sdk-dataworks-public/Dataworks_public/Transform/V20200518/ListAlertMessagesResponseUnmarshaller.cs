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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListAlertMessagesResponseUnmarshaller
    {
        public static ListAlertMessagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListAlertMessagesResponse listAlertMessagesResponse = new ListAlertMessagesResponse();

			listAlertMessagesResponse.HttpResponse = context.HttpResponse;
			listAlertMessagesResponse.Success = context.BooleanValue("ListAlertMessages.Success");
			listAlertMessagesResponse.ErrorCode = context.StringValue("ListAlertMessages.ErrorCode");
			listAlertMessagesResponse.ErrorMessage = context.StringValue("ListAlertMessages.ErrorMessage");
			listAlertMessagesResponse.HttpStatusCode = context.IntegerValue("ListAlertMessages.HttpStatusCode");
			listAlertMessagesResponse.RequestId = context.StringValue("ListAlertMessages.RequestId");

			ListAlertMessagesResponse.ListAlertMessages_Data data = new ListAlertMessagesResponse.ListAlertMessages_Data();
			data.PageNumber = context.StringValue("ListAlertMessages.Data.PageNumber");
			data.PageSize = context.StringValue("ListAlertMessages.Data.PageSize");
			data.TotalCount = context.StringValue("ListAlertMessages.Data.TotalCount");

			List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem> data_alertMessages = new List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem>();
			for (int i = 0; i < context.Length("ListAlertMessages.Data.AlertMessages.Length"); i++) {
				ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem alertMessagesItem = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem();
				alertMessagesItem.AlertId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertId");
				alertMessagesItem.AlertTime = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertTime");
				alertMessagesItem.Source = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Source");
				alertMessagesItem.RemindId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].RemindId");
				alertMessagesItem.RemindName = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].RemindName");
				alertMessagesItem.AlertUser = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertUser");
				alertMessagesItem.AlertMethod = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertMethod");
				alertMessagesItem.AlertMessageStatus = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertMessageStatus");
				alertMessagesItem.Content = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Content");

				ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_SlaAlert slaAlert = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_SlaAlert();
				slaAlert.BaselineId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.BaselineId");
				slaAlert.BaselineName = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.BaselineName");
				slaAlert.BaselineOwner = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.BaselineOwner");
				slaAlert.Bizdate = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.Bizdate");
				slaAlert.InGroupId = context.IntegerValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.InGroupId");
				slaAlert.ProjectId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.ProjectId");
				slaAlert.Status = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.Status");
				alertMessagesItem.SlaAlert = slaAlert;

				List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_InstancesItem> alertMessagesItem_instances = new List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_InstancesItem>();
				for (int j = 0; j < context.Length("ListAlertMessages.Data.AlertMessages["+ i +"].Instances.Length"); j++) {
					ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_InstancesItem instancesItem = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_InstancesItem();
					instancesItem.NodeId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].NodeId");
					instancesItem.NodeName = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].NodeName");
					instancesItem.ProjectId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].ProjectId");
					instancesItem.Status = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].Status");
					instancesItem.InstanceId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].InstanceId");

					alertMessagesItem_instances.Add(instancesItem);
				}
				alertMessagesItem.Instances = alertMessagesItem_instances;

				List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_TopicsItem> alertMessagesItem_topics = new List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_TopicsItem>();
				for (int j = 0; j < context.Length("ListAlertMessages.Data.AlertMessages["+ i +"].Topics.Length"); j++) {
					ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_TopicsItem topicsItem = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_TopicsItem();
					topicsItem.NodeId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].NodeId");
					topicsItem.InstanceId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].InstanceId");
					topicsItem.TopicId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].TopicId");
					topicsItem.TopicName = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].TopicName");
					topicsItem.TopicOwner = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].TopicOwner");
					topicsItem.TopicStatus = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].TopicStatus");

					alertMessagesItem_topics.Add(topicsItem);
				}
				alertMessagesItem.Topics = alertMessagesItem_topics;

				List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_NodesItem> alertMessagesItem_nodes = new List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_NodesItem>();
				for (int j = 0; j < context.Length("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes.Length"); j++) {
					ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_NodesItem nodesItem = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_NodesItem();
					nodesItem.NodeId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes["+ j +"].NodeId");
					nodesItem.NodeName = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes["+ j +"].NodeName");
					nodesItem.Owner = context.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes["+ j +"].Owner");
					nodesItem.ProjectId = context.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes["+ j +"].ProjectId");

					alertMessagesItem_nodes.Add(nodesItem);
				}
				alertMessagesItem.Nodes = alertMessagesItem_nodes;

				data_alertMessages.Add(alertMessagesItem);
			}
			data.AlertMessages = data_alertMessages;
			listAlertMessagesResponse.Data = data;
        
			return listAlertMessagesResponse;
        }
    }
}
