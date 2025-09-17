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
using Aliyun.Acs.marketplaceIntl;
using Aliyun.Acs.marketplaceIntl.Transform;
using Aliyun.Acs.marketplaceIntl.Transform.V20221230;

namespace Aliyun.Acs.marketplaceIntl.Model.V20221230
{
    public class PushMeteringDataRequest : RpcAcsRequest<PushMeteringDataResponse>
    {
        public PushMeteringDataRequest()
            : base("marketplaceIntl", "2022-12-30", "PushMeteringData")
        {
			Method = MethodType.POST;
        }

		private List<string> meteringDatas = new List<string>(){ };

		private string gmtCreate;

		public List<string> MeteringDatas
		{
			get
			{
				return meteringDatas;
			}

			set
			{
				meteringDatas = value;
				if(meteringDatas != null)
				{
					for (int depth1 = 0; depth1 < meteringDatas.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"MeteringData." + (depth1 + 1), meteringDatas[depth1]);
						DictionaryUtil.Add(BodyParameters,"MeteringData." + (depth1 + 1), meteringDatas[depth1]);
						DictionaryUtil.Add(BodyParameters,"MeteringData." + (depth1 + 1), meteringDatas[depth1]);
						DictionaryUtil.Add(BodyParameters,"MeteringData." + (depth1 + 1), meteringDatas[depth1]);
						DictionaryUtil.Add(BodyParameters,"MeteringData." + (depth1 + 1), meteringDatas[depth1]);
						DictionaryUtil.Add(BodyParameters,"MeteringData." + (depth1 + 1), meteringDatas[depth1]);
					}
				}
			}
		}

		public string GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
				DictionaryUtil.Add(BodyParameters, "GmtCreate", value);
			}
		}

		public class MeteringData
		{

			private string meteringAssist;

			private string pushOrderBizId;

			private string instanceId;

			private long? endTime;

			private long? startTime;

			private string meteringEntity;

			public string MeteringAssist
			{
				get
				{
					return meteringAssist;
				}
				set	
				{
					meteringAssist = value;
				}
			}

			public string PushOrderBizId
			{
				get
				{
					return pushOrderBizId;
				}
				set	
				{
					pushOrderBizId = value;
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

			public string MeteringEntity
			{
				get
				{
					return meteringEntity;
				}
				set	
				{
					meteringEntity = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PushMeteringDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PushMeteringDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
