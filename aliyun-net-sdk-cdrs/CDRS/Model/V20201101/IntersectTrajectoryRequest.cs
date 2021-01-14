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
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class IntersectTrajectoryRequest : RpcAcsRequest<IntersectTrajectoryResponse>
    {
        public IntersectTrajectoryRequest()
            : base("CDRS", "2020-11-01", "IntersectTrajectory")
        {
			Method = MethodType.POST;
        }

		private string corpId;

		private string endTime;

		private int? deltaDistance;

		private string startTime;

		private int? deltaTime;

		private List<IdList> idLists = new List<IdList>(){ };

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
			}
		}

		public int? DeltaDistance
		{
			get
			{
				return deltaDistance;
			}
			set	
			{
				deltaDistance = value;
				DictionaryUtil.Add(BodyParameters, "DeltaDistance", value.ToString());
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value);
			}
		}

		public int? DeltaTime
		{
			get
			{
				return deltaTime;
			}
			set	
			{
				deltaTime = value;
				DictionaryUtil.Add(BodyParameters, "DeltaTime", value.ToString());
			}
		}

		public List<IdList> IdLists
		{
			get
			{
				return idLists;
			}

			set
			{
				idLists = value;
				for (int i = 0; i < idLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"IdList." + (i + 1) + ".IdType", idLists[i].IdType);
					DictionaryUtil.Add(BodyParameters,"IdList." + (i + 1) + ".IdValue", idLists[i].IdValue);
				}
			}
		}

		public class IdList
		{

			private string idType;

			private string idValue;

			public string IdType
			{
				get
				{
					return idType;
				}
				set	
				{
					idType = value;
				}
			}

			public string IdValue
			{
				get
				{
					return idValue;
				}
				set	
				{
					idValue = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override IntersectTrajectoryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return IntersectTrajectoryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
