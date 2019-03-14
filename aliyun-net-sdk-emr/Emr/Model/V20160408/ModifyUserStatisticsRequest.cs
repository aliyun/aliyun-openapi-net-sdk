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
    public class ModifyUserStatisticsRequest : RpcAcsRequest<ModifyUserStatisticsResponse>
    {
        public ModifyUserStatisticsRequest()
            : base("Emr", "2016-04-08", "ModifyUserStatistics", "emr", "openAPI")
        {
        }

		private int? jobMigratedNum;

		private long? resourceOwnerId;

		private int? executePlanNum;

		private string regionId;

		private int? jobNum;

		private int? executePlanMigratedNum;

		private int? interactionJobMigratedNum;

		private string userId;

		private string accessKeyId;

		private int? interactionJobNum;

		public int? JobMigratedNum
		{
			get
			{
				return jobMigratedNum;
			}
			set	
			{
				jobMigratedNum = value;
				DictionaryUtil.Add(QueryParameters, "JobMigratedNum", value.ToString());
			}
		}

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

		public int? ExecutePlanNum
		{
			get
			{
				return executePlanNum;
			}
			set	
			{
				executePlanNum = value;
				DictionaryUtil.Add(QueryParameters, "ExecutePlanNum", value.ToString());
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

		public int? JobNum
		{
			get
			{
				return jobNum;
			}
			set	
			{
				jobNum = value;
				DictionaryUtil.Add(QueryParameters, "JobNum", value.ToString());
			}
		}

		public int? ExecutePlanMigratedNum
		{
			get
			{
				return executePlanMigratedNum;
			}
			set	
			{
				executePlanMigratedNum = value;
				DictionaryUtil.Add(QueryParameters, "ExecutePlanMigratedNum", value.ToString());
			}
		}

		public int? InteractionJobMigratedNum
		{
			get
			{
				return interactionJobMigratedNum;
			}
			set	
			{
				interactionJobMigratedNum = value;
				DictionaryUtil.Add(QueryParameters, "InteractionJobMigratedNum", value.ToString());
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
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

		public int? InteractionJobNum
		{
			get
			{
				return interactionJobNum;
			}
			set	
			{
				interactionJobNum = value;
				DictionaryUtil.Add(QueryParameters, "InteractionJobNum", value.ToString());
			}
		}

        public override ModifyUserStatisticsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyUserStatisticsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
