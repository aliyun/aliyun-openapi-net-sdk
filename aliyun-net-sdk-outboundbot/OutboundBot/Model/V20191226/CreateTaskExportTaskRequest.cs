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
using Aliyun.Acs.OutboundBot;
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class CreateTaskExportTaskRequest : RpcAcsRequest<CreateTaskExportTaskResponse>
    {
        public CreateTaskExportTaskRequest()
            : base("OutboundBot", "2019-12-26", "CreateTaskExportTask")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
        }

		private bool? hasAnswered;

		private long? actualTimeLte;

		private string otherId;

		private long? taskCreateTimeLte;

		private string jobId;

		private long? taskCreateTimeGte;

		private string calledNumber;

		private string userIdMatch;

		private int? pageSize;

		private string scriptNameQuery;

		private int? pageIndex;

		private string sortOrder;

		private string taskStatusStringList;

		private string jobGroupNameQuery;

		private string taskId;

		private bool? hasHangUpByRejection;

		private bool? hasReachedEndOfFlow;

		private string instanceId;

		private long? recordingDurationGte;

		private long? callDurationLte;

		private string jobGroupId;

		private string sortBy;

		private string jobStatusStringList;

		private long? actualTimeGte;

		private long? callDurationGte;

		private long? recordingDurationLte;

		public bool? HasAnswered
		{
			get
			{
				return hasAnswered;
			}
			set	
			{
				hasAnswered = value;
				DictionaryUtil.Add(QueryParameters, "HasAnswered", value.ToString());
			}
		}

		public long? ActualTimeLte
		{
			get
			{
				return actualTimeLte;
			}
			set	
			{
				actualTimeLte = value;
				DictionaryUtil.Add(QueryParameters, "ActualTimeLte", value.ToString());
			}
		}

		public string OtherId
		{
			get
			{
				return otherId;
			}
			set	
			{
				otherId = value;
				DictionaryUtil.Add(QueryParameters, "OtherId", value);
			}
		}

		public long? TaskCreateTimeLte
		{
			get
			{
				return taskCreateTimeLte;
			}
			set	
			{
				taskCreateTimeLte = value;
				DictionaryUtil.Add(QueryParameters, "TaskCreateTimeLte", value.ToString());
			}
		}

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(QueryParameters, "JobId", value);
			}
		}

		public long? TaskCreateTimeGte
		{
			get
			{
				return taskCreateTimeGte;
			}
			set	
			{
				taskCreateTimeGte = value;
				DictionaryUtil.Add(QueryParameters, "TaskCreateTimeGte", value.ToString());
			}
		}

		public string CalledNumber
		{
			get
			{
				return calledNumber;
			}
			set	
			{
				calledNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledNumber", value);
			}
		}

		public string UserIdMatch
		{
			get
			{
				return userIdMatch;
			}
			set	
			{
				userIdMatch = value;
				DictionaryUtil.Add(QueryParameters, "UserIdMatch", value);
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

		public string ScriptNameQuery
		{
			get
			{
				return scriptNameQuery;
			}
			set	
			{
				scriptNameQuery = value;
				DictionaryUtil.Add(QueryParameters, "ScriptNameQuery", value);
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(QueryParameters, "PageIndex", value.ToString());
			}
		}

		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(QueryParameters, "SortOrder", value);
			}
		}

		public string TaskStatusStringList
		{
			get
			{
				return taskStatusStringList;
			}
			set	
			{
				taskStatusStringList = value;
				DictionaryUtil.Add(QueryParameters, "TaskStatusStringList", value);
			}
		}

		public string JobGroupNameQuery
		{
			get
			{
				return jobGroupNameQuery;
			}
			set	
			{
				jobGroupNameQuery = value;
				DictionaryUtil.Add(QueryParameters, "JobGroupNameQuery", value);
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

		public bool? HasHangUpByRejection
		{
			get
			{
				return hasHangUpByRejection;
			}
			set	
			{
				hasHangUpByRejection = value;
				DictionaryUtil.Add(QueryParameters, "HasHangUpByRejection", value.ToString());
			}
		}

		public bool? HasReachedEndOfFlow
		{
			get
			{
				return hasReachedEndOfFlow;
			}
			set	
			{
				hasReachedEndOfFlow = value;
				DictionaryUtil.Add(QueryParameters, "HasReachedEndOfFlow", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public long? RecordingDurationGte
		{
			get
			{
				return recordingDurationGte;
			}
			set	
			{
				recordingDurationGte = value;
				DictionaryUtil.Add(QueryParameters, "RecordingDurationGte", value.ToString());
			}
		}

		public long? CallDurationLte
		{
			get
			{
				return callDurationLte;
			}
			set	
			{
				callDurationLte = value;
				DictionaryUtil.Add(QueryParameters, "CallDurationLte", value.ToString());
			}
		}

		public string JobGroupId
		{
			get
			{
				return jobGroupId;
			}
			set	
			{
				jobGroupId = value;
				DictionaryUtil.Add(QueryParameters, "JobGroupId", value);
			}
		}

		public string SortBy
		{
			get
			{
				return sortBy;
			}
			set	
			{
				sortBy = value;
				DictionaryUtil.Add(QueryParameters, "SortBy", value);
			}
		}

		public string JobStatusStringList
		{
			get
			{
				return jobStatusStringList;
			}
			set	
			{
				jobStatusStringList = value;
				DictionaryUtil.Add(QueryParameters, "JobStatusStringList", value);
			}
		}

		public long? ActualTimeGte
		{
			get
			{
				return actualTimeGte;
			}
			set	
			{
				actualTimeGte = value;
				DictionaryUtil.Add(QueryParameters, "ActualTimeGte", value.ToString());
			}
		}

		public long? CallDurationGte
		{
			get
			{
				return callDurationGte;
			}
			set	
			{
				callDurationGte = value;
				DictionaryUtil.Add(QueryParameters, "CallDurationGte", value.ToString());
			}
		}

		public long? RecordingDurationLte
		{
			get
			{
				return recordingDurationLte;
			}
			set	
			{
				recordingDurationLte = value;
				DictionaryUtil.Add(QueryParameters, "RecordingDurationLte", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTaskExportTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTaskExportTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
