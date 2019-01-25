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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class DescribeDialogFlowResponseUnmarshaller
    {
        public static DescribeDialogFlowResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDialogFlowResponse describeDialogFlowResponse = new DescribeDialogFlowResponse();

			describeDialogFlowResponse.HttpResponse = context.HttpResponse;
			describeDialogFlowResponse.RequestId = context.StringValue("DescribeDialogFlow.RequestId");
			describeDialogFlowResponse.DialogId = context.LongValue("DescribeDialogFlow.DialogId");
			describeDialogFlowResponse.InstanceId = context.StringValue("DescribeDialogFlow.InstanceId");
			describeDialogFlowResponse.DialogName = context.StringValue("DescribeDialogFlow.DialogName");
			describeDialogFlowResponse.ModuleId = context.LongValue("DescribeDialogFlow.ModuleId");
			describeDialogFlowResponse.ModuleName = context.StringValue("DescribeDialogFlow.ModuleName");
			describeDialogFlowResponse.Templates = context.StringValue("DescribeDialogFlow.Templates");
			describeDialogFlowResponse.CreateTime = context.StringValue("DescribeDialogFlow.CreateTime");
			describeDialogFlowResponse.ModifyTime = context.StringValue("DescribeDialogFlow.ModifyTime");
			describeDialogFlowResponse.CreateUserId = context.StringValue("DescribeDialogFlow.CreateUserId");
			describeDialogFlowResponse.CreateUserName = context.StringValue("DescribeDialogFlow.CreateUserName");
			describeDialogFlowResponse.ModifyUserId = context.StringValue("DescribeDialogFlow.ModifyUserId");
			describeDialogFlowResponse.ModifyUserName = context.StringValue("DescribeDialogFlow.ModifyUserName");
			describeDialogFlowResponse.AccountId = context.StringValue("DescribeDialogFlow.AccountId");
			describeDialogFlowResponse.Tags = context.StringValue("DescribeDialogFlow.Tags");
			describeDialogFlowResponse.Status = context.IntegerValue("DescribeDialogFlow.Status");

			DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition moduleDefinition = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition();

			List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem> moduleDefinition_nodes = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem>();
			for (int i = 0; i < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes.Length"); i++) {
				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem nodesItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem();
				nodesItem.Code = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].Code");
				nodesItem.ComponentCode = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].ComponentCode");
				nodesItem.PluginDataUpdate = context.BooleanValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginDataUpdate");
				nodesItem.Xx = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].Xx");
				nodesItem.Yy = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].Yy");
				nodesItem.Id = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].Id");
				nodesItem.Label = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].Label");

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData pluginData = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData();

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry entry = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry();

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry pluginFieldDataEntry = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry();
				pluginFieldDataEntry.LifeSpan = context.IntegerValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.LifeSpan");
				pluginFieldDataEntry.Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.Name");

				List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem> pluginFieldDataEntry_contentEntry = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem>();
				for (int j = 0; j < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry.Length"); j++) {
					DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem contentEntryItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem();

					List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem.DescribeDialogFlow_ConditionEntriesItem> contentEntryItem_conditionEntries = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem.DescribeDialogFlow_ConditionEntriesItem>();
					for (int k = 0; k < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry["+ j +"].ConditionEntries.Length"); k++) {
						DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem.DescribeDialogFlow_ConditionEntriesItem conditionEntriesItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem.DescribeDialogFlow_ConditionEntriesItem();
						conditionEntriesItem.Id = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry["+ j +"].ConditionEntries["+ k +"].Id");
						conditionEntriesItem.Term = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry["+ j +"].ConditionEntries["+ k +"].Term");
						conditionEntriesItem.Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry["+ j +"].ConditionEntries["+ k +"].Name");
						conditionEntriesItem.Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry["+ j +"].ConditionEntries["+ k +"].Type");
						conditionEntriesItem._Value = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry["+ j +"].ConditionEntries["+ k +"].Value");

						contentEntryItem_conditionEntries.Add(conditionEntriesItem);
					}
					contentEntryItem.ConditionEntries = contentEntryItem_conditionEntries;

					pluginFieldDataEntry_contentEntry.Add(contentEntryItem);
				}
				pluginFieldDataEntry.ContentEntry = pluginFieldDataEntry_contentEntry;
				entry.PluginFieldDataEntry = pluginFieldDataEntry;
				pluginData.Entry = entry;

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function function = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function();

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction pluginFieldDataFunction = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction();
				pluginFieldDataFunction.Code = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Code");
				pluginFieldDataFunction.Description = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Description");
				pluginFieldDataFunction.Function = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Function");
				pluginFieldDataFunction.Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Name");
				pluginFieldDataFunction.AliyunService = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.AliyunService");
				pluginFieldDataFunction.AliyunFunction = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.AliyunFunction");
				pluginFieldDataFunction.EndPoint = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.EndPoint");
				pluginFieldDataFunction.Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Type");
				pluginFieldDataFunction._Params = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Params");

				List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction.DescribeDialogFlow_SwitchItem> pluginFieldDataFunction_switch = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction.DescribeDialogFlow_SwitchItem>();
				for (int j = 0; j < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Switch.Length"); j++) {
					DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction.DescribeDialogFlow_SwitchItem switchItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction.DescribeDialogFlow_SwitchItem();
					switchItem.Id = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Switch["+ j +"].Id");
					switchItem.Label = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Switch["+ j +"].Label");
					switchItem.Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Switch["+ j +"].Type");
					switchItem._Value = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Switch["+ j +"].Value");
					switchItem.Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Switch["+ j +"].Name");

					pluginFieldDataFunction_switch.Add(switchItem);
				}
				pluginFieldDataFunction._Switch = pluginFieldDataFunction_switch;
				function.PluginFieldDataFunction = pluginFieldDataFunction;
				pluginData.Function = function;

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response response = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response();

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse pluginFieldDataResponse = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse();
				pluginFieldDataResponse.Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.Name");

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse contentResponse = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse();
				contentResponse.Text = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.Text");
				contentResponse.Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.Type");
				contentResponse.Image = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.Image");

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList buttonList = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList();
				buttonList.Intro = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Intro");

				List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList.DescribeDialogFlow_ButtonItem> buttonList_button = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList.DescribeDialogFlow_ButtonItem>();
				for (int j = 0; j < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Button.Length"); j++) {
					DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList.DescribeDialogFlow_ButtonItem buttonItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList.DescribeDialogFlow_ButtonItem();
					buttonItem.Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Button["+ j +"].Name");
					buttonItem.Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Button["+ j +"].Type");
					buttonItem.Text = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Button["+ j +"].Text");

					buttonList_button.Add(buttonItem);
				}
				buttonList.Button = buttonList_button;
				contentResponse.ButtonList = buttonList;
				pluginFieldDataResponse.ContentResponse = contentResponse;
				response.PluginFieldDataResponse = pluginFieldDataResponse;
				pluginData.Response = response;

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot slot = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot();

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot pluginFieldDataSlot = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot();
				pluginFieldDataSlot.IntentId = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.IntentId");
				pluginFieldDataSlot.IntentName = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.IntentName");
				pluginFieldDataSlot.IsSysIntent = context.BooleanValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.IsSysIntent");
				pluginFieldDataSlot.Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.Name");

				List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot.DescribeDialogFlow_ContentSlotItem> pluginFieldDataSlot_contentSlot = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot.DescribeDialogFlow_ContentSlotItem>();
				for (int j = 0; j < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot.Length"); j++) {
					DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot.DescribeDialogFlow_ContentSlotItem contentSlotItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot.DescribeDialogFlow_ContentSlotItem();
					contentSlotItem.IsArray = context.BooleanValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot["+ j +"].IsArray");
					contentSlotItem.IsNecessary = context.BooleanValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot["+ j +"].IsNecessary");
					contentSlotItem.LifeSpan = context.IntegerValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot["+ j +"].LifeSpan");
					contentSlotItem.Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot["+ j +"].Name");
					contentSlotItem._Value = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot["+ j +"].Value");

					List<string> contentSlotItem_question = new List<string>();
					for (int k = 0; k < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot["+ j +"].Question.Length"); k++) {
						contentSlotItem_question.Add(context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot["+ j +"].Question["+ k +"]"));
					}
					contentSlotItem.Question = contentSlotItem_question;

					pluginFieldDataSlot_contentSlot.Add(contentSlotItem);
				}
				pluginFieldDataSlot.ContentSlot = pluginFieldDataSlot_contentSlot;
				slot.PluginFieldDataSlot = pluginFieldDataSlot;
				pluginData.Slot = slot;
				nodesItem.PluginData = pluginData;

				moduleDefinition_nodes.Add(nodesItem);
			}
			moduleDefinition.Nodes = moduleDefinition_nodes;

			List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_EdgesItem> moduleDefinition_edges = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_EdgesItem>();
			for (int i = 0; i < context.Length("DescribeDialogFlow.ModuleDefinition.Edges.Length"); i++) {
				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_EdgesItem edgesItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_EdgesItem();
				edgesItem.Id = context.StringValue("DescribeDialogFlow.ModuleDefinition.Edges["+ i +"].Id");
				edgesItem.Label = context.StringValue("DescribeDialogFlow.ModuleDefinition.Edges["+ i +"].Label");
				edgesItem.Source = context.StringValue("DescribeDialogFlow.ModuleDefinition.Edges["+ i +"].Source");
				edgesItem.Target = context.StringValue("DescribeDialogFlow.ModuleDefinition.Edges["+ i +"].Target");

				moduleDefinition_edges.Add(edgesItem);
			}
			moduleDefinition.Edges = moduleDefinition_edges;
			describeDialogFlowResponse.ModuleDefinition = moduleDefinition;
        
			return describeDialogFlowResponse;
        }
    }
}