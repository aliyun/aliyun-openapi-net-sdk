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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class DescribeDialogFlowResponse : AcsResponse
	{
        public new string RequestId { get; set; }

        public long? DialogId { get; set; }

        public string InstanceId { get; set; }

        public string DialogName { get; set; }

        public long? ModuleId { get; set; }

        public string ModuleName { get; set; }

        public string Templates { get; set; }

        public string CreateTime { get; set; }

        public string ModifyTime { get; set; }

        public string CreateUserId { get; set; }

        public string CreateUserName { get; set; }

        public string ModifyUserId { get; set; }

        public string ModifyUserName { get; set; }

        public string AccountId { get; set; }

        public string Tags { get; set; }

        public int? Status { get; set; }

        public DescribeDialogFlow_ModuleDefinition ModuleDefinition { get; set; }

        public class DescribeDialogFlow_ModuleDefinition
		{
            public List<DescribeDialogFlow_NodesItem> Nodes { get; set; }

            public List<DescribeDialogFlow_EdgesItem> Edges { get; set; }

            public class DescribeDialogFlow_NodesItem
			{
                public string Code { get; set; }

                public string ComponentCode { get; set; }

                public bool? PluginDataUpdate { get; set; }

                public string Xx { get; set; }

                public string Yy { get; set; }

                public string Id { get; set; }

                public string Label { get; set; }

                public DescribeDialogFlow_PluginData PluginData { get; set; }

                public class DescribeDialogFlow_PluginData
				{
                    public DescribeDialogFlow_Entry Entry { get; set; }

                    public DescribeDialogFlow_Function Function { get; set; }

                    public DescribeDialogFlow_Response Response { get; set; }

                    public DescribeDialogFlow_Slot Slot { get; set; }

                    public class DescribeDialogFlow_Entry
					{
                        public DescribeDialogFlow_PluginFieldDataEntry PluginFieldDataEntry { get; set; }

                        public class DescribeDialogFlow_PluginFieldDataEntry
						{
                            public int? LifeSpan { get; set; }

                            public string Name { get; set; }

                            public List<DescribeDialogFlow_ContentEntryItem> ContentEntry { get; set; }

                            public class DescribeDialogFlow_ContentEntryItem
							{
                                public List<DescribeDialogFlow_ConditionEntriesItem> ConditionEntries { get; set; }

                                public class DescribeDialogFlow_ConditionEntriesItem
								{
                                    public string Id { get; set; }

                                    public string Term { get; set; }

                                    public string Name { get; set; }

                                    public string Type { get; set; }

                                    public string _Value { get; set; }
                                }
							}
						}
					}

					public class DescribeDialogFlow_Function
					{
                        public DescribeDialogFlow_PluginFieldDataFunction PluginFieldDataFunction { get; set; }

                        public class DescribeDialogFlow_PluginFieldDataFunction
						{
                            public string Code { get; set; }

                            public string Description { get; set; }

                            public string Function { get; set; }

                            public string Name { get; set; }

                            public string AliyunService { get; set; }

                            public string AliyunFunction { get; set; }

                            public string EndPoint { get; set; }

                            public string Type { get; set; }

                            public string _Params { get; set; }

                            public List<DescribeDialogFlow_SwitchItem> _Switch { get; set; }

                            public class DescribeDialogFlow_SwitchItem
							{
                                public string Id { get; set; }

                                public string Label { get; set; }

                                public string Type { get; set; }

                                public string _Value { get; set; }

                                public string Name { get; set; }
                            }
						}
					}

					public class DescribeDialogFlow_Response
					{
                        public DescribeDialogFlow_PluginFieldDataResponse PluginFieldDataResponse { get; set; }

                        public class DescribeDialogFlow_PluginFieldDataResponse
						{
                            public string Name { get; set; }

                            public DescribeDialogFlow_ContentResponse ContentResponse { get; set; }

                            public class DescribeDialogFlow_ContentResponse
							{
                                public string Text { get; set; }

                                public string Type { get; set; }

                                public string Image { get; set; }

                                public DescribeDialogFlow_ButtonList ButtonList { get; set; }

                                public class DescribeDialogFlow_ButtonList
								{
                                    public string Intro { get; set; }

                                    public List<DescribeDialogFlow_ButtonItem> Button { get; set; }

                                    public class DescribeDialogFlow_ButtonItem
									{
                                        public string Name { get; set; }

                                        public string Type { get; set; }

                                        public string Text { get; set; }
                                    }
								}
							}
						}
					}

					public class DescribeDialogFlow_Slot
					{
                        public DescribeDialogFlow_PluginFieldDataSlot PluginFieldDataSlot { get; set; }

                        public class DescribeDialogFlow_PluginFieldDataSlot
						{
                            public string IntentId { get; set; }

                            public string IntentName { get; set; }

                            public bool? IsSysIntent { get; set; }

                            public string Name { get; set; }

                            public List<DescribeDialogFlow_ContentSlotItem> ContentSlot { get; set; }

                            public class DescribeDialogFlow_ContentSlotItem
							{
                                public bool? IsArray { get; set; }

                                public bool? IsNecessary { get; set; }

                                public int? LifeSpan { get; set; }

                                public string Name { get; set; }

                                public string _Value { get; set; }

                                public List<string> Question { get; set; }
                            }
						}
					}
				}
			}

			public class DescribeDialogFlow_EdgesItem
			{
                public string Id { get; set; }

                public string Label { get; set; }

                public string Source { get; set; }

                public string Target { get; set; }
            }
		}
	}
}