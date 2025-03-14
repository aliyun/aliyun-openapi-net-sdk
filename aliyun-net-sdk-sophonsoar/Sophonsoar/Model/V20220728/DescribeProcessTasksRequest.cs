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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.sophonsoar;
using Aliyun.Acs.sophonsoar.Transform;
using Aliyun.Acs.sophonsoar.Transform.V20220728;

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
    public class DescribeProcessTasksRequest : RpcAcsRequest<DescribeProcessTasksResponse>
    {
        public DescribeProcessTasksRequest()
            : base("sophonsoar", "2022-07-28", "DescribeProcessTasks")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string entityName;

		private string yunCode;

		private string source;

		private long? pageNumber;

		private string taskStatus;

		private long? processRemoveEnd;

		private string paramContent;

		private string scope;

		private int? pageSize;

		private string triggerSource;

		private long? processRemoveStart;

		private string taskId;

		private string orderField;

		private string direction;

		private string sceneCode;

		private long? processActionStart;

		private long? processActionEnd;

		private string processStrategyUuid;

		private string entityType;

		private string entityUuid;

		private string eventUuid;

		public string EntityName
		{
			get
			{
				return entityName;
			}
			set	
			{
				entityName = value;
				DictionaryUtil.Add(QueryParameters, "EntityName", value);
			}
		}

		public string YunCode
		{
			get
			{
				return yunCode;
			}
			set	
			{
				yunCode = value;
				DictionaryUtil.Add(QueryParameters, "YunCode", value);
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
				DictionaryUtil.Add(QueryParameters, "Source", value);
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
				DictionaryUtil.Add(QueryParameters, "TaskStatus", value);
			}
		}

		public long? ProcessRemoveEnd
		{
			get
			{
				return processRemoveEnd;
			}
			set	
			{
				processRemoveEnd = value;
				DictionaryUtil.Add(QueryParameters, "ProcessRemoveEnd", value.ToString());
			}
		}

		public string ParamContent
		{
			get
			{
				return paramContent;
			}
			set	
			{
				paramContent = value;
				DictionaryUtil.Add(QueryParameters, "ParamContent", value);
			}
		}

		public string Scope
		{
			get
			{
				return scope;
			}
			set	
			{
				scope = value;
				DictionaryUtil.Add(QueryParameters, "Scope", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string TriggerSource
		{
			get
			{
				return triggerSource;
			}
			set	
			{
				triggerSource = value;
				DictionaryUtil.Add(QueryParameters, "TriggerSource", value);
			}
		}

		public long? ProcessRemoveStart
		{
			get
			{
				return processRemoveStart;
			}
			set	
			{
				processRemoveStart = value;
				DictionaryUtil.Add(QueryParameters, "ProcessRemoveStart", value.ToString());
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

		public string OrderField
		{
			get
			{
				return orderField;
			}
			set	
			{
				orderField = value;
				DictionaryUtil.Add(QueryParameters, "OrderField", value);
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

		public string SceneCode
		{
			get
			{
				return sceneCode;
			}
			set	
			{
				sceneCode = value;
				DictionaryUtil.Add(QueryParameters, "SceneCode", value);
			}
		}

		public long? ProcessActionStart
		{
			get
			{
				return processActionStart;
			}
			set	
			{
				processActionStart = value;
				DictionaryUtil.Add(QueryParameters, "ProcessActionStart", value.ToString());
			}
		}

		public long? ProcessActionEnd
		{
			get
			{
				return processActionEnd;
			}
			set	
			{
				processActionEnd = value;
				DictionaryUtil.Add(QueryParameters, "ProcessActionEnd", value.ToString());
			}
		}

		public string ProcessStrategyUuid
		{
			get
			{
				return processStrategyUuid;
			}
			set	
			{
				processStrategyUuid = value;
				DictionaryUtil.Add(QueryParameters, "ProcessStrategyUuid", value);
			}
		}

		public string EntityType
		{
			get
			{
				return entityType;
			}
			set	
			{
				entityType = value;
				DictionaryUtil.Add(QueryParameters, "EntityType", value);
			}
		}

		public string EntityUuid
		{
			get
			{
				return entityUuid;
			}
			set	
			{
				entityUuid = value;
				DictionaryUtil.Add(QueryParameters, "EntityUuid", value);
			}
		}

		public string EventUuid
		{
			get
			{
				return eventUuid;
			}
			set	
			{
				eventUuid = value;
				DictionaryUtil.Add(QueryParameters, "EventUuid", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeProcessTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeProcessTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
