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
using Aliyun.Acs.Sas;
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class DescribeSuspEventsRequest : RpcAcsRequest<DescribeSuspEventsResponse>
    {
        public DescribeSuspEventsRequest()
            : base("Sas", "2018-12-03", "DescribeSuspEvents")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string source;

		private string containerFieldName;

		private string sourceIp;

		private string eventNames;

		private string from;

		private long? id;

		private string tacticId;

		private string alarmUniqueInfo;

		private string uniqueInfo;

		private long? groupId;

		private string operateTimeEnd;

		private string name;

		private string status;

		private string uuids;

		private string timeEnd;

		private string targetType;

		private string remark;

		private string containerFieldValue;

		private string pageSize;

		private string lang;

		private string dealed;

		private string currentPage;

		private string clusterId;

		private List<string> operateErrorCodeLists = new List<string>(){ };

		private string operateTimeStart;

		private string timeStart;

		private string levels;

		private string parentEventTypes;

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

		public string ContainerFieldName
		{
			get
			{
				return containerFieldName;
			}
			set	
			{
				containerFieldName = value;
				DictionaryUtil.Add(QueryParameters, "ContainerFieldName", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string EventNames
		{
			get
			{
				return eventNames;
			}
			set	
			{
				eventNames = value;
				DictionaryUtil.Add(QueryParameters, "EventNames", value);
			}
		}

		public string From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string TacticId
		{
			get
			{
				return tacticId;
			}
			set	
			{
				tacticId = value;
				DictionaryUtil.Add(BodyParameters, "TacticId", value);
			}
		}

		public string AlarmUniqueInfo
		{
			get
			{
				return alarmUniqueInfo;
			}
			set	
			{
				alarmUniqueInfo = value;
				DictionaryUtil.Add(QueryParameters, "AlarmUniqueInfo", value);
			}
		}

		public string UniqueInfo
		{
			get
			{
				return uniqueInfo;
			}
			set	
			{
				uniqueInfo = value;
				DictionaryUtil.Add(QueryParameters, "UniqueInfo", value);
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
			}
		}

		public string OperateTimeEnd
		{
			get
			{
				return operateTimeEnd;
			}
			set	
			{
				operateTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "OperateTimeEnd", value);
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public string Uuids
		{
			get
			{
				return uuids;
			}
			set	
			{
				uuids = value;
				DictionaryUtil.Add(QueryParameters, "Uuids", value);
			}
		}

		public string TimeEnd
		{
			get
			{
				return timeEnd;
			}
			set	
			{
				timeEnd = value;
				DictionaryUtil.Add(QueryParameters, "TimeEnd", value);
			}
		}

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
				DictionaryUtil.Add(QueryParameters, "TargetType", value);
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
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string ContainerFieldValue
		{
			get
			{
				return containerFieldValue;
			}
			set	
			{
				containerFieldValue = value;
				DictionaryUtil.Add(QueryParameters, "ContainerFieldValue", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Dealed
		{
			get
			{
				return dealed;
			}
			set	
			{
				dealed = value;
				DictionaryUtil.Add(QueryParameters, "Dealed", value);
			}
		}

		public string CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public List<string> OperateErrorCodeLists
		{
			get
			{
				return operateErrorCodeLists;
			}

			set
			{
				operateErrorCodeLists = value;
			}
		}

		public string OperateTimeStart
		{
			get
			{
				return operateTimeStart;
			}
			set	
			{
				operateTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "OperateTimeStart", value);
			}
		}

		public string TimeStart
		{
			get
			{
				return timeStart;
			}
			set	
			{
				timeStart = value;
				DictionaryUtil.Add(QueryParameters, "TimeStart", value);
			}
		}

		public string Levels
		{
			get
			{
				return levels;
			}
			set	
			{
				levels = value;
				DictionaryUtil.Add(QueryParameters, "Levels", value);
			}
		}

		public string ParentEventTypes
		{
			get
			{
				return parentEventTypes;
			}
			set	
			{
				parentEventTypes = value;
				DictionaryUtil.Add(QueryParameters, "ParentEventTypes", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSuspEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSuspEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
