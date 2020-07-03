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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsTopicListResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private List<OnsTopicList_PublishInfoDo> data;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public List<OnsTopicList_PublishInfoDo> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class OnsTopicList_PublishInfoDo
		{

			private string topic;

			private string owner;

			private int? relation;

			private string relationName;

			private long? createTime;

			private string remark;

			private int? messageType;

			private string instanceId;

			private bool? independentNaming;

			private List<OnsTopicList_Tag> tags;

			public string Topic
			{
				get
				{
					return topic;
				}
				set	
				{
					topic = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public int? Relation
			{
				get
				{
					return relation;
				}
				set	
				{
					relation = value;
				}
			}

			public string RelationName
			{
				get
				{
					return relationName;
				}
				set	
				{
					relationName = value;
				}
			}

			public long? CreateTime
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

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public int? MessageType
			{
				get
				{
					return messageType;
				}
				set	
				{
					messageType = value;
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

			public bool? IndependentNaming
			{
				get
				{
					return independentNaming;
				}
				set	
				{
					independentNaming = value;
				}
			}

			public List<OnsTopicList_Tag> Tags
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

			public class OnsTopicList_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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
