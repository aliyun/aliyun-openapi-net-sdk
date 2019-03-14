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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class UpdateETLJobRequest : RpcAcsRequest<UpdateETLJobResponse>
    {
        public UpdateETLJobRequest()
            : base("Emr", "2016-04-08", "UpdateETLJob", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private List<StageConnection> stageConnections;

		private string clusterConfig;

		private List<TriggerRule> triggerRules;

		private List<Stage> stages;

		private string regionId;

		private string alertConfig;

		private string name;

		private string description;

		private string id;

		private bool? check;

		private string accessKeyId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public List<StageConnection> StageConnections
		{
			get
			{
				return stageConnections;
			}

			set
			{
				stageConnections = value;
				for (int i = 0; i < stageConnections.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"StageConnection." + (i + 1) + ".Port", stageConnections[i].Port);
					DictionaryUtil.Add(QueryParameters,"StageConnection." + (i + 1) + ".From", stageConnections[i].From);
					DictionaryUtil.Add(QueryParameters,"StageConnection." + (i + 1) + ".To", stageConnections[i].To);
				}
			}
		}

		public string ClusterConfig
		{
			get
			{
				return clusterConfig;
			}
			set	
			{
				clusterConfig = value;
				DictionaryUtil.Add(QueryParameters, "ClusterConfig", value);
			}
		}

		public List<TriggerRule> TriggerRules
		{
			get
			{
				return triggerRules;
			}

			set
			{
				triggerRules = value;
				for (int i = 0; i < triggerRules.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TriggerRule." + (i + 1) + ".CronExpr", triggerRules[i].CronExpr);
					DictionaryUtil.Add(QueryParameters,"TriggerRule." + (i + 1) + ".EndTime", triggerRules[i].EndTime);
					DictionaryUtil.Add(QueryParameters,"TriggerRule." + (i + 1) + ".StartTime", triggerRules[i].StartTime);
					DictionaryUtil.Add(QueryParameters,"TriggerRule." + (i + 1) + ".Enabled", triggerRules[i].Enabled);
				}
			}
		}

		public List<Stage> Stages
		{
			get
			{
				return stages;
			}

			set
			{
				stages = value;
				for (int i = 0; i < stages.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Stage." + (i + 1) + ".StageName", stages[i].StageName);
					DictionaryUtil.Add(QueryParameters,"Stage." + (i + 1) + ".StageConf", stages[i].StageConf);
					DictionaryUtil.Add(QueryParameters,"Stage." + (i + 1) + ".StageType", stages[i].StageType);
					DictionaryUtil.Add(QueryParameters,"Stage." + (i + 1) + ".StagePlugin", stages[i].StagePlugin);
				}
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string AlertConfig
		{
			get
			{
				return alertConfig;
			}
			set	
			{
				alertConfig = value;
				DictionaryUtil.Add(QueryParameters, "AlertConfig", value);
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

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public bool? Check
		{
			get
			{
				return check;
			}
			set	
			{
				check = value;
				DictionaryUtil.Add(QueryParameters, "Check", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public class StageConnection
		{

			private string port;

			private string from;

			private string to;

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
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
				}
			}

			public string To
			{
				get
				{
					return to;
				}
				set	
				{
					to = value;
				}
			}
		}

		public class TriggerRule
		{

			private string cronExpr;

			private long? endTime;

			private long? startTime;

			private bool? enabled;

			public string CronExpr
			{
				get
				{
					return cronExpr;
				}
				set	
				{
					cronExpr = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}
		}

		public class Stage
		{

			private string stageName;

			private string stageConf;

			private string stageType;

			private string stagePlugin;

			public string StageName
			{
				get
				{
					return stageName;
				}
				set	
				{
					stageName = value;
				}
			}

			public string StageConf
			{
				get
				{
					return stageConf;
				}
				set	
				{
					stageConf = value;
				}
			}

			public string StageType
			{
				get
				{
					return stageType;
				}
				set	
				{
					stageType = value;
				}
			}

			public string StagePlugin
			{
				get
				{
					return stagePlugin;
				}
				set	
				{
					stagePlugin = value;
				}
			}
		}

        public override UpdateETLJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateETLJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
