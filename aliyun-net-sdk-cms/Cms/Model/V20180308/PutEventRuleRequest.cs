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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class PutEventRuleRequest : RpcAcsRequest<PutEventRuleResponse>
    {
        public PutEventRuleRequest()
            : base("Cms", "2018-03-08", "PutEventRule", "cms", "openAPI")
        {
        }

		private List<EventPattern> eventPatterns;

		private string groupId;

		private string name;

		private string description;

		private string eventType;

		private string state;

		public List<EventPattern> EventPatterns
		{
			get
			{
				return eventPatterns;
			}

			set
			{
				eventPatterns = value;
				for (int i = 0; i < eventPatterns.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"EventPattern." + (i + 1) + ".Product", eventPatterns[i].Product);
					for (int j = 0; j < eventPatterns[i].NameLists.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"EventPattern." + (i + 1) + ".NameList." +(j + 1), eventPatterns[i].NameLists[j]);
					}
					for (int j = 0; j < eventPatterns[i].StatusLists.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"EventPattern." + (i + 1) + ".StatusList." +(j + 1), eventPatterns[i].StatusLists[j]);
					}
					for (int j = 0; j < eventPatterns[i].LevelLists.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"EventPattern." + (i + 1) + ".LevelList." +(j + 1), eventPatterns[i].LevelLists[j]);
					}
				}
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string EventType
		{
			get
			{
				return eventType;
			}
			set	
			{
				eventType = value;
				DictionaryUtil.Add(QueryParameters, "EventType", value);
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value);
			}
		}

		public class EventPattern
		{

			private string product;

			private List<string> nameLists;

			private List<string> statusLists;

			private List<string> levelLists;

			public string Product
			{
				get
				{
					return product;
				}
				set	
				{
					product = value;
				}
			}

			public List<string> NameLists
			{
				get
				{
					return nameLists;
				}
				set	
				{
					nameLists = value;
				}
			}

			public List<string> StatusLists
			{
				get
				{
					return statusLists;
				}
				set	
				{
					statusLists = value;
				}
			}

			public List<string> LevelLists
			{
				get
				{
					return levelLists;
				}
				set	
				{
					levelLists = value;
				}
			}
		}

        public override PutEventRuleResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PutEventRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}