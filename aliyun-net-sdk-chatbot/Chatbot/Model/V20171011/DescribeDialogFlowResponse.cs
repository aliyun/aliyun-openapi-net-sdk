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

		private string requestId;

		private long? dialogId;

		private string instanceId;

		private string dialogName;

		private long? moduleId;

		private string moduleName;

		private string templates;

		private string createTime;

		private string modifyTime;

		private string createUserId;

		private string createUserName;

		private string modifyUserId;

		private string modifyUserName;

		private string accountId;

		private string tags;

		private int? status;

		private DescribeDialogFlow_ModuleDefinition moduleDefinition;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public long? DialogId
		{
			get
			{
				return dialogId;
			}
			set	
			{
				dialogId = value;
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public string DialogName
		{
			get
			{
				return dialogName;
			}
			set	
			{
				dialogName = value;
			}
		}

		public long? ModuleId
		{
			get
			{
				return moduleId;
			}
			set	
			{
				moduleId = value;
			}
		}

		public string ModuleName
		{
			get
			{
				return moduleName;
			}
			set	
			{
				moduleName = value;
			}
		}

		public string Templates
		{
			get
			{
				return templates;
			}
			set	
			{
				templates = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public string ModifyTime
		{
			get
			{
				return modifyTime;
			}
			set	
			{
				modifyTime = value;
			}
		}

		public string CreateUserId
		{
			get
			{
				return createUserId;
			}
			set	
			{
				createUserId = value;
			}
		}

		public string CreateUserName
		{
			get
			{
				return createUserName;
			}
			set	
			{
				createUserName = value;
			}
		}

		public string ModifyUserId
		{
			get
			{
				return modifyUserId;
			}
			set	
			{
				modifyUserId = value;
			}
		}

		public string ModifyUserName
		{
			get
			{
				return modifyUserName;
			}
			set	
			{
				modifyUserName = value;
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public DescribeDialogFlow_ModuleDefinition ModuleDefinition
		{
			get
			{
				return moduleDefinition;
			}
			set	
			{
				moduleDefinition = value;
			}
		}

		public class DescribeDialogFlow_ModuleDefinition
		{

			private List<DescribeDialogFlow_NodesItem> nodes;

			private List<DescribeDialogFlow_EdgesItem> edges;

			public List<DescribeDialogFlow_NodesItem> Nodes
			{
				get
				{
					return nodes;
				}
				set	
				{
					nodes = value;
				}
			}

			public List<DescribeDialogFlow_EdgesItem> Edges
			{
				get
				{
					return edges;
				}
				set	
				{
					edges = value;
				}
			}

			public class DescribeDialogFlow_NodesItem
			{

				private string code;

				private string componentCode;

				private bool? pluginDataUpdate;

				private string xx;

				private string yy;

				private string id;

				private string label;

				private DescribeDialogFlow_PluginData pluginData;

				public string Code
				{
					get
					{
						return code;
					}
					set	
					{
						code = value;
					}
				}

				public string ComponentCode
				{
					get
					{
						return componentCode;
					}
					set	
					{
						componentCode = value;
					}
				}

				public bool? PluginDataUpdate
				{
					get
					{
						return pluginDataUpdate;
					}
					set	
					{
						pluginDataUpdate = value;
					}
				}

				public string Xx
				{
					get
					{
						return xx;
					}
					set	
					{
						xx = value;
					}
				}

				public string Yy
				{
					get
					{
						return yy;
					}
					set	
					{
						yy = value;
					}
				}

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public DescribeDialogFlow_PluginData PluginData
				{
					get
					{
						return pluginData;
					}
					set	
					{
						pluginData = value;
					}
				}

				public class DescribeDialogFlow_PluginData
				{

					private DescribeDialogFlow_Entry entry;

					private DescribeDialogFlow_Function function;

					private DescribeDialogFlow_Response response;

					private DescribeDialogFlow_Slot slot;

					public DescribeDialogFlow_Entry Entry
					{
						get
						{
							return entry;
						}
						set	
						{
							entry = value;
						}
					}

					public DescribeDialogFlow_Function Function
					{
						get
						{
							return function;
						}
						set	
						{
							function = value;
						}
					}

					public DescribeDialogFlow_Response Response
					{
						get
						{
							return response;
						}
						set	
						{
							response = value;
						}
					}

					public DescribeDialogFlow_Slot Slot
					{
						get
						{
							return slot;
						}
						set	
						{
							slot = value;
						}
					}

					public class DescribeDialogFlow_Entry
					{

						private DescribeDialogFlow_PluginFieldDataEntry pluginFieldDataEntry;

						public DescribeDialogFlow_PluginFieldDataEntry PluginFieldDataEntry
						{
							get
							{
								return pluginFieldDataEntry;
							}
							set	
							{
								pluginFieldDataEntry = value;
							}
						}

						public class DescribeDialogFlow_PluginFieldDataEntry
						{

							private int? lifeSpan;

							private string name;

							private List<DescribeDialogFlow_ContentEntryItem> contentEntry;

							public int? LifeSpan
							{
								get
								{
									return lifeSpan;
								}
								set	
								{
									lifeSpan = value;
								}
							}

							public string Name
							{
								get
								{
									return name;
								}
								set	
								{
									name = value;
								}
							}

							public List<DescribeDialogFlow_ContentEntryItem> ContentEntry
							{
								get
								{
									return contentEntry;
								}
								set	
								{
									contentEntry = value;
								}
							}

							public class DescribeDialogFlow_ContentEntryItem
							{

								private List<DescribeDialogFlow_ConditionEntriesItem> conditionEntries;

								public List<DescribeDialogFlow_ConditionEntriesItem> ConditionEntries
								{
									get
									{
										return conditionEntries;
									}
									set	
									{
										conditionEntries = value;
									}
								}

								public class DescribeDialogFlow_ConditionEntriesItem
								{

									private string id;

									private string term;

									private string name;

									private string type;

									private string _value;

									public string Id
									{
										get
										{
											return id;
										}
										set	
										{
											id = value;
										}
									}

									public string Term
									{
										get
										{
											return term;
										}
										set	
										{
											term = value;
										}
									}

									public string Name
									{
										get
										{
											return name;
										}
										set	
										{
											name = value;
										}
									}

									public string Type
									{
										get
										{
											return type;
										}
										set	
										{
											type = value;
										}
									}

									public string _Value
									{
										get
										{
											return _value;
										}
										set	
										{
											_value = value;
										}
									}
								}
							}
						}
					}

					public class DescribeDialogFlow_Function
					{

						private DescribeDialogFlow_PluginFieldDataFunction pluginFieldDataFunction;

						public DescribeDialogFlow_PluginFieldDataFunction PluginFieldDataFunction
						{
							get
							{
								return pluginFieldDataFunction;
							}
							set	
							{
								pluginFieldDataFunction = value;
							}
						}

						public class DescribeDialogFlow_PluginFieldDataFunction
						{

							private string code;

							private string description;

							private string function;

							private string name;

							private string aliyunService;

							private string aliyunFunction;

							private string endPoint;

							private string type;

							private string _params;

							private List<DescribeDialogFlow_SwitchItem> _switch;

							public string Code
							{
								get
								{
									return code;
								}
								set	
								{
									code = value;
								}
							}

							public string Description
							{
								get
								{
									return description;
								}
								set	
								{
									description = value;
								}
							}

							public string Function
							{
								get
								{
									return function;
								}
								set	
								{
									function = value;
								}
							}

							public string Name
							{
								get
								{
									return name;
								}
								set	
								{
									name = value;
								}
							}

							public string AliyunService
							{
								get
								{
									return aliyunService;
								}
								set	
								{
									aliyunService = value;
								}
							}

							public string AliyunFunction
							{
								get
								{
									return aliyunFunction;
								}
								set	
								{
									aliyunFunction = value;
								}
							}

							public string EndPoint
							{
								get
								{
									return endPoint;
								}
								set	
								{
									endPoint = value;
								}
							}

							public string Type
							{
								get
								{
									return type;
								}
								set	
								{
									type = value;
								}
							}

							public string _Params
							{
								get
								{
									return _params;
								}
								set	
								{
									_params = value;
								}
							}

							public List<DescribeDialogFlow_SwitchItem> _Switch
							{
								get
								{
									return _switch;
								}
								set	
								{
									_switch = value;
								}
							}

							public class DescribeDialogFlow_SwitchItem
							{

								private string id;

								private string label;

								private string type;

								private string _value;

								private string name;

								public string Id
								{
									get
									{
										return id;
									}
									set	
									{
										id = value;
									}
								}

								public string Label
								{
									get
									{
										return label;
									}
									set	
									{
										label = value;
									}
								}

								public string Type
								{
									get
									{
										return type;
									}
									set	
									{
										type = value;
									}
								}

								public string _Value
								{
									get
									{
										return _value;
									}
									set	
									{
										_value = value;
									}
								}

								public string Name
								{
									get
									{
										return name;
									}
									set	
									{
										name = value;
									}
								}
							}
						}
					}

					public class DescribeDialogFlow_Response
					{

						private DescribeDialogFlow_PluginFieldDataResponse pluginFieldDataResponse;

						public DescribeDialogFlow_PluginFieldDataResponse PluginFieldDataResponse
						{
							get
							{
								return pluginFieldDataResponse;
							}
							set	
							{
								pluginFieldDataResponse = value;
							}
						}

						public class DescribeDialogFlow_PluginFieldDataResponse
						{

							private string name;

							private DescribeDialogFlow_ContentResponse contentResponse;

							public string Name
							{
								get
								{
									return name;
								}
								set	
								{
									name = value;
								}
							}

							public DescribeDialogFlow_ContentResponse ContentResponse
							{
								get
								{
									return contentResponse;
								}
								set	
								{
									contentResponse = value;
								}
							}

							public class DescribeDialogFlow_ContentResponse
							{

								private string text;

								private string type;

								private string image;

								private DescribeDialogFlow_ButtonList buttonList;

								public string Text
								{
									get
									{
										return text;
									}
									set	
									{
										text = value;
									}
								}

								public string Type
								{
									get
									{
										return type;
									}
									set	
									{
										type = value;
									}
								}

								public string Image
								{
									get
									{
										return image;
									}
									set	
									{
										image = value;
									}
								}

								public DescribeDialogFlow_ButtonList ButtonList
								{
									get
									{
										return buttonList;
									}
									set	
									{
										buttonList = value;
									}
								}

								public class DescribeDialogFlow_ButtonList
								{

									private string intro;

									private List<DescribeDialogFlow_ButtonItem> button;

									public string Intro
									{
										get
										{
											return intro;
										}
										set	
										{
											intro = value;
										}
									}

									public List<DescribeDialogFlow_ButtonItem> Button
									{
										get
										{
											return button;
										}
										set	
										{
											button = value;
										}
									}

									public class DescribeDialogFlow_ButtonItem
									{

										private string name;

										private string type;

										private string text;

										public string Name
										{
											get
											{
												return name;
											}
											set	
											{
												name = value;
											}
										}

										public string Type
										{
											get
											{
												return type;
											}
											set	
											{
												type = value;
											}
										}

										public string Text
										{
											get
											{
												return text;
											}
											set	
											{
												text = value;
											}
										}
									}
								}
							}
						}
					}

					public class DescribeDialogFlow_Slot
					{

						private DescribeDialogFlow_PluginFieldDataSlot pluginFieldDataSlot;

						public DescribeDialogFlow_PluginFieldDataSlot PluginFieldDataSlot
						{
							get
							{
								return pluginFieldDataSlot;
							}
							set	
							{
								pluginFieldDataSlot = value;
							}
						}

						public class DescribeDialogFlow_PluginFieldDataSlot
						{

							private string intentId;

							private string intentName;

							private bool? isSysIntent;

							private string name;

							private List<DescribeDialogFlow_ContentSlotItem> contentSlot;

							public string IntentId
							{
								get
								{
									return intentId;
								}
								set	
								{
									intentId = value;
								}
							}

							public string IntentName
							{
								get
								{
									return intentName;
								}
								set	
								{
									intentName = value;
								}
							}

							public bool? IsSysIntent
							{
								get
								{
									return isSysIntent;
								}
								set	
								{
									isSysIntent = value;
								}
							}

							public string Name
							{
								get
								{
									return name;
								}
								set	
								{
									name = value;
								}
							}

							public List<DescribeDialogFlow_ContentSlotItem> ContentSlot
							{
								get
								{
									return contentSlot;
								}
								set	
								{
									contentSlot = value;
								}
							}

							public class DescribeDialogFlow_ContentSlotItem
							{

								private bool? isArray;

								private bool? isNecessary;

								private int? lifeSpan;

								private string name;

								private string _value;

								private List<string> question;

								public bool? IsArray
								{
									get
									{
										return isArray;
									}
									set	
									{
										isArray = value;
									}
								}

								public bool? IsNecessary
								{
									get
									{
										return isNecessary;
									}
									set	
									{
										isNecessary = value;
									}
								}

								public int? LifeSpan
								{
									get
									{
										return lifeSpan;
									}
									set	
									{
										lifeSpan = value;
									}
								}

								public string Name
								{
									get
									{
										return name;
									}
									set	
									{
										name = value;
									}
								}

								public string _Value
								{
									get
									{
										return _value;
									}
									set	
									{
										_value = value;
									}
								}

								public List<string> Question
								{
									get
									{
										return question;
									}
									set	
									{
										question = value;
									}
								}
							}
						}
					}
				}
			}

			public class DescribeDialogFlow_EdgesItem
			{

				private string id;

				private string label;

				private string source;

				private string target;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}

				public string Target
				{
					get
					{
						return target;
					}
					set	
					{
						target = value;
					}
				}
			}
		}
	}
}