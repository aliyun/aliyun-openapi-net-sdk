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
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class SetSchedulerInfoRequest : RpcAcsRequest<SetSchedulerInfoResponse>
    {
        public SetSchedulerInfoRequest()
            : base("EHPC", "2018-04-12", "SetSchedulerInfo")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private List<SlurmInfo> slurmInfos = new List<SlurmInfo>(){ };

		private string clusterId;

		private List<Scheduler> schedulers = new List<Scheduler>(){ };

		private List<PbsInfo> pbsInfos = new List<PbsInfo>(){ };

		public List<SlurmInfo> SlurmInfos
		{
			get
			{
				return slurmInfos;
			}

			set
			{
				slurmInfos = value;
				for (int i = 0; i < slurmInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SlurmInfo." + (i + 1) + ".SchedInterval", slurmInfos[i].SchedInterval);
					DictionaryUtil.Add(QueryParameters,"SlurmInfo." + (i + 1) + ".BackfillInterval", slurmInfos[i].BackfillInterval);
				}
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

		public List<Scheduler> Schedulers
		{
			get
			{
				return schedulers;
			}

			set
			{
				schedulers = value;
				for (int i = 0; i < schedulers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Scheduler." + (i + 1) + ".SchedName", schedulers[i].SchedName);
				}
			}
		}

		public List<PbsInfo> PbsInfos
		{
			get
			{
				return pbsInfos;
			}

			set
			{
				pbsInfos = value;
				for (int i = 0; i < pbsInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PbsInfo." + (i + 1) + ".SchedInterval", pbsInfos[i].SchedInterval);
					for (int j = 0; j < pbsInfos[i].ResourceLimits.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"PbsInfo." + (i + 1) + ".ResourceLimit." +(j + 1), pbsInfos[i].ResourceLimits[j]);
					}
					for (int j = 0; j < pbsInfos[i].AclLimits.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"PbsInfo." + (i + 1) + ".AclLimit." +(j + 1), pbsInfos[i].AclLimits[j]);
					}
					DictionaryUtil.Add(QueryParameters,"PbsInfo." + (i + 1) + ".JobHistoryDuration", pbsInfos[i].JobHistoryDuration);
				}
			}
		}

		public class SlurmInfo
		{

			private int? schedInterval;

			private int? backfillInterval;

			public int? SchedInterval
			{
				get
				{
					return schedInterval;
				}
				set	
				{
					schedInterval = value;
				}
			}

			public int? BackfillInterval
			{
				get
				{
					return backfillInterval;
				}
				set	
				{
					backfillInterval = value;
				}
			}
		}

		public class Scheduler
		{

			private string schedName;

			public string SchedName
			{
				get
				{
					return schedName;
				}
				set	
				{
					schedName = value;
				}
			}
		}

		public class PbsInfo
		{

			private int? schedInterval;

			private List<ResourceLimit> resourceLimits = new List<ResourceLimit>(){ };

			private List<AclLimit> aclLimits = new List<AclLimit>(){ };

			private int? jobHistoryDuration;

			public int? SchedInterval
			{
				get
				{
					return schedInterval;
				}
				set	
				{
					schedInterval = value;
				}
			}

			public List<ResourceLimit> ResourceLimits
			{
				get
				{
					return resourceLimits;
				}
				set	
				{
					resourceLimits = value;
				}
			}

			public List<AclLimit> AclLimits
			{
				get
				{
					return aclLimits;
				}
				set	
				{
					aclLimits = value;
				}
			}

			public int? JobHistoryDuration
			{
				get
				{
					return jobHistoryDuration;
				}
				set	
				{
					jobHistoryDuration = value;
				}
			}

			public class ResourceLimit
			{

				private int? nodes;

				private string mem;

				private int? cpus;

				private string user;

				private string queue;

				public int? Nodes
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

				public string Mem
				{
					get
					{
						return mem;
					}
					set	
					{
						mem = value;
					}
				}

				public int? Cpus
				{
					get
					{
						return cpus;
					}
					set	
					{
						cpus = value;
					}
				}

				public string User
				{
					get
					{
						return user;
					}
					set	
					{
						user = value;
					}
				}

				public string Queue
				{
					get
					{
						return queue;
					}
					set	
					{
						queue = value;
					}
				}
			}

			public class AclLimit
			{

				private string aclUsers;

				private string queue;

				public string AclUsers
				{
					get
					{
						return aclUsers;
					}
					set	
					{
						aclUsers = value;
					}
				}

				public string Queue
				{
					get
					{
						return queue;
					}
					set	
					{
						queue = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetSchedulerInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetSchedulerInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
