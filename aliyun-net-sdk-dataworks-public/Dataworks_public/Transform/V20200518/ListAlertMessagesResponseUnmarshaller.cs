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
        public static ListAlertMessagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAlertMessagesResponse listAlertMessagesResponse = new ListAlertMessagesResponse();

			listAlertMessagesResponse.HttpResponse = _ctx.HttpResponse;
			listAlertMessagesResponse.HttpStatusCode = _ctx.IntegerValue("ListAlertMessages.HttpStatusCode");
			listAlertMessagesResponse.RequestId = _ctx.StringValue("ListAlertMessages.RequestId");
			listAlertMessagesResponse.ErrorMessage = _ctx.StringValue("ListAlertMessages.ErrorMessage");
			listAlertMessagesResponse.ErrorCode = _ctx.StringValue("ListAlertMessages.ErrorCode");
			listAlertMessagesResponse.Success = _ctx.BooleanValue("ListAlertMessages.Success");

			ListAlertMessagesResponse.ListAlertMessages_Data data = new ListAlertMessagesResponse.ListAlertMessages_Data();
			data.PageNumber = _ctx.StringValue("ListAlertMessages.Data.PageNumber");
			data.PageSize = _ctx.StringValue("ListAlertMessages.Data.PageSize");
			data.TotalCount = _ctx.StringValue("ListAlertMessages.Data.TotalCount");

			List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem> data_alertMessages = new List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem>();
			for (int i = 0; i < _ctx.Length("ListAlertMessages.Data.AlertMessages.Length"); i++) {
				ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem alertMessagesItem = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem();
				alertMessagesItem.RemindId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].RemindId");
				alertMessagesItem.AlertMessageStatus = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertMessageStatus");
				alertMessagesItem.AlertUser = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertUser");
				alertMessagesItem.AlertTime = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertTime");
				alertMessagesItem.AlertMethod = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertMethod");
				alertMessagesItem.Source = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Source");
				alertMessagesItem.Content = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Content");
				alertMessagesItem.RemindName = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].RemindName");
				alertMessagesItem.AlertId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].AlertId");

				ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_SlaAlert slaAlert = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_SlaAlert();
				slaAlert.Status = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.Status");
				slaAlert.BaselineOwner = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.BaselineOwner");
				slaAlert.BaselineId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.BaselineId");
				slaAlert.BaselineName = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.BaselineName");
				slaAlert.Bizdate = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.Bizdate");
				slaAlert.ProjectId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.ProjectId");
				slaAlert.InGroupId = _ctx.IntegerValue("ListAlertMessages.Data.AlertMessages["+ i +"].SlaAlert.InGroupId");
				alertMessagesItem.SlaAlert = slaAlert;

				List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_InstancesItem> alertMessagesItem_instances = new List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_InstancesItem>();
				for (int j = 0; j < _ctx.Length("ListAlertMessages.Data.AlertMessages["+ i +"].Instances.Length"); j++) {
					ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_InstancesItem instancesItem = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_InstancesItem();
					instancesItem.Status = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].Status");
					instancesItem.InstanceId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].InstanceId");
					instancesItem.NodeName = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].NodeName");
					instancesItem.NodeId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].NodeId");
					instancesItem.ProjectId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Instances["+ j +"].ProjectId");

					alertMessagesItem_instances.Add(instancesItem);
				}
				alertMessagesItem.Instances = alertMessagesItem_instances;

				List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_TopicsItem> alertMessagesItem_topics = new List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_TopicsItem>();
				for (int j = 0; j < _ctx.Length("ListAlertMessages.Data.AlertMessages["+ i +"].Topics.Length"); j++) {
					ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_TopicsItem topicsItem = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_TopicsItem();
					topicsItem.TopicName = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].TopicName");
					topicsItem.InstanceId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].InstanceId");
					topicsItem.TopicId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].TopicId");
					topicsItem.TopicOwner = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].TopicOwner");
					topicsItem.NodeId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].NodeId");
					topicsItem.TopicStatus = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Topics["+ j +"].TopicStatus");

					alertMessagesItem_topics.Add(topicsItem);
				}
				alertMessagesItem.Topics = alertMessagesItem_topics;

				List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_NodesItem> alertMessagesItem_nodes = new List<ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_NodesItem>();
				for (int j = 0; j < _ctx.Length("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes.Length"); j++) {
					ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_NodesItem nodesItem = new ListAlertMessagesResponse.ListAlertMessages_Data.ListAlertMessages_AlertMessagesItem.ListAlertMessages_NodesItem();
					nodesItem.Owner = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes["+ j +"].Owner");
					nodesItem.NodeName = _ctx.StringValue("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes["+ j +"].NodeName");
					nodesItem.NodeId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes["+ j +"].NodeId");
					nodesItem.ProjectId = _ctx.LongValue("ListAlertMessages.Data.AlertMessages["+ i +"].Nodes["+ j +"].ProjectId");

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
