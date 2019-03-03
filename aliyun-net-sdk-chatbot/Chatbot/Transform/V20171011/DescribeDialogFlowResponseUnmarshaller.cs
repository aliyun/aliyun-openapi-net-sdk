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
            DescribeDialogFlowResponse describeDialogFlowResponse = new DescribeDialogFlowResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDialogFlow.RequestId"),
                DialogId = context.LongValue("DescribeDialogFlow.DialogId"),
                InstanceId = context.StringValue("DescribeDialogFlow.InstanceId"),
                DialogName = context.StringValue("DescribeDialogFlow.DialogName"),
                ModuleId = context.LongValue("DescribeDialogFlow.ModuleId"),
                ModuleName = context.StringValue("DescribeDialogFlow.ModuleName"),
                Templates = context.StringValue("DescribeDialogFlow.Templates"),
                CreateTime = context.StringValue("DescribeDialogFlow.CreateTime"),
                ModifyTime = context.StringValue("DescribeDialogFlow.ModifyTime"),
                CreateUserId = context.StringValue("DescribeDialogFlow.CreateUserId"),
                CreateUserName = context.StringValue("DescribeDialogFlow.CreateUserName"),
                ModifyUserId = context.StringValue("DescribeDialogFlow.ModifyUserId"),
                ModifyUserName = context.StringValue("DescribeDialogFlow.ModifyUserName"),
                AccountId = context.StringValue("DescribeDialogFlow.AccountId"),
                Tags = context.StringValue("DescribeDialogFlow.Tags"),
                Status = context.IntegerValue("DescribeDialogFlow.Status")
            };

            DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition moduleDefinition = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition();

			List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem> moduleDefinition_nodes = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem>();
			for (int i = 0; i < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes.Length"); i++) {
                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem nodesItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem
                {
                    Code = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].Code"),
                    ComponentCode = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].ComponentCode"),
                    PluginDataUpdate = context.BooleanValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginDataUpdate"),
                    Xx = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].Xx"),
                    Yy = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].Yy"),
                    Id = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].Id"),
                    Label = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].Label")
                };

                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData pluginData = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData();

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry entry = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry();

                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry pluginFieldDataEntry = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry
                {
                    LifeSpan = context.IntegerValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Entry.PluginFieldDataEntry.LifeSpan"),
                    Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Entry.PluginFieldDataEntry.Name")
                };

                List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem> pluginFieldDataEntry_contentEntry = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem>();
				for (int j = 0; j < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry.Length"); j++) {
					DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem contentEntryItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem();

					List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem.DescribeDialogFlow_ConditionEntriesItem> contentEntryItem_conditionEntries = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem.DescribeDialogFlow_ConditionEntriesItem>();
					for (int k = 0; k < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Entry.PluginFieldDataEntry.ContentEntry["+ j +"].ConditionEntries.Length"); k++) {
                        DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem.DescribeDialogFlow_ConditionEntriesItem conditionEntriesItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Entry.DescribeDialogFlow_PluginFieldDataEntry.DescribeDialogFlow_ContentEntryItem.DescribeDialogFlow_ConditionEntriesItem
                        {
                            Id = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Entry.PluginFieldDataEntry.ContentEntry[" + j + "].ConditionEntries[" + k + "].Id"),
                            Term = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Entry.PluginFieldDataEntry.ContentEntry[" + j + "].ConditionEntries[" + k + "].Term"),
                            Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Entry.PluginFieldDataEntry.ContentEntry[" + j + "].ConditionEntries[" + k + "].Name"),
                            Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Entry.PluginFieldDataEntry.ContentEntry[" + j + "].ConditionEntries[" + k + "].Type"),
                            _Value = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Entry.PluginFieldDataEntry.ContentEntry[" + j + "].ConditionEntries[" + k + "].Value")
                        };

                        contentEntryItem_conditionEntries.Add(conditionEntriesItem);
					}
					contentEntryItem.ConditionEntries = contentEntryItem_conditionEntries;

					pluginFieldDataEntry_contentEntry.Add(contentEntryItem);
				}
				pluginFieldDataEntry.ContentEntry = pluginFieldDataEntry_contentEntry;
				entry.PluginFieldDataEntry = pluginFieldDataEntry;
				pluginData.Entry = entry;

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function function = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function();

                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction pluginFieldDataFunction = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction
                {
                    Code = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Code"),
                    Description = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Description"),
                    Function = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Function"),
                    Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Name"),
                    AliyunService = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.AliyunService"),
                    AliyunFunction = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.AliyunFunction"),
                    EndPoint = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.EndPoint"),
                    Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Type"),
                    _Params = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Params")
                };

                List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction.DescribeDialogFlow_SwitchItem> pluginFieldDataFunction_switch = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction.DescribeDialogFlow_SwitchItem>();
				for (int j = 0; j < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Function.PluginFieldDataFunction.Switch.Length"); j++) {
                    DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction.DescribeDialogFlow_SwitchItem switchItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Function.DescribeDialogFlow_PluginFieldDataFunction.DescribeDialogFlow_SwitchItem
                    {
                        Id = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Switch[" + j + "].Id"),
                        Label = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Switch[" + j + "].Label"),
                        Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Switch[" + j + "].Type"),
                        _Value = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Switch[" + j + "].Value"),
                        Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Function.PluginFieldDataFunction.Switch[" + j + "].Name")
                    };

                    pluginFieldDataFunction_switch.Add(switchItem);
				}
				pluginFieldDataFunction._Switch = pluginFieldDataFunction_switch;
				function.PluginFieldDataFunction = pluginFieldDataFunction;
				pluginData.Function = function;

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response response = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response();

                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse pluginFieldDataResponse = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse
                {
                    Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Response.PluginFieldDataResponse.Name")
                };

                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse contentResponse = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse
                {
                    Text = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Response.PluginFieldDataResponse.ContentResponse.Text"),
                    Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Response.PluginFieldDataResponse.ContentResponse.Type"),
                    Image = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Response.PluginFieldDataResponse.ContentResponse.Image")
                };

                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList buttonList = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList
                {
                    Intro = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Intro")
                };

                List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList.DescribeDialogFlow_ButtonItem> buttonList_button = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList.DescribeDialogFlow_ButtonItem>();
				for (int j = 0; j < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Button.Length"); j++) {
                    DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList.DescribeDialogFlow_ButtonItem buttonItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Response.DescribeDialogFlow_PluginFieldDataResponse.DescribeDialogFlow_ContentResponse.DescribeDialogFlow_ButtonList.DescribeDialogFlow_ButtonItem
                    {
                        Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Button[" + j + "].Name"),
                        Type = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Button[" + j + "].Type"),
                        Text = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Response.PluginFieldDataResponse.ContentResponse.ButtonList.Button[" + j + "].Text")
                    };

                    buttonList_button.Add(buttonItem);
				}
				buttonList.Button = buttonList_button;
				contentResponse.ButtonList = buttonList;
				pluginFieldDataResponse.ContentResponse = contentResponse;
				response.PluginFieldDataResponse = pluginFieldDataResponse;
				pluginData.Response = response;

				DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot slot = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot();

                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot pluginFieldDataSlot = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot
                {
                    IntentId = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.IntentId"),
                    IntentName = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.IntentName"),
                    IsSysIntent = context.BooleanValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.IsSysIntent"),
                    Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.Name")
                };

                List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot.DescribeDialogFlow_ContentSlotItem> pluginFieldDataSlot_contentSlot = new List<DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot.DescribeDialogFlow_ContentSlotItem>();
				for (int j = 0; j < context.Length("DescribeDialogFlow.ModuleDefinition.Nodes["+ i +"].PluginData.Slot.PluginFieldDataSlot.ContentSlot.Length"); j++) {
                    DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot.DescribeDialogFlow_ContentSlotItem contentSlotItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_NodesItem.DescribeDialogFlow_PluginData.DescribeDialogFlow_Slot.DescribeDialogFlow_PluginFieldDataSlot.DescribeDialogFlow_ContentSlotItem
                    {
                        IsArray = context.BooleanValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.ContentSlot[" + j + "].IsArray"),
                        IsNecessary = context.BooleanValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.ContentSlot[" + j + "].IsNecessary"),
                        LifeSpan = context.IntegerValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.ContentSlot[" + j + "].LifeSpan"),
                        Name = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.ContentSlot[" + j + "].Name"),
                        _Value = context.StringValue("DescribeDialogFlow.ModuleDefinition.Nodes[" + i + "].PluginData.Slot.PluginFieldDataSlot.ContentSlot[" + j + "].Value")
                    };

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
                DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_EdgesItem edgesItem = new DescribeDialogFlowResponse.DescribeDialogFlow_ModuleDefinition.DescribeDialogFlow_EdgesItem
                {
                    Id = context.StringValue("DescribeDialogFlow.ModuleDefinition.Edges[" + i + "].Id"),
                    Label = context.StringValue("DescribeDialogFlow.ModuleDefinition.Edges[" + i + "].Label"),
                    Source = context.StringValue("DescribeDialogFlow.ModuleDefinition.Edges[" + i + "].Source"),
                    Target = context.StringValue("DescribeDialogFlow.ModuleDefinition.Edges[" + i + "].Target")
                };

                moduleDefinition_edges.Add(edgesItem);
			}
			moduleDefinition.Edges = moduleDefinition_edges;
			describeDialogFlowResponse.ModuleDefinition = moduleDefinition;
        
			return describeDialogFlowResponse;
        }
    }
}