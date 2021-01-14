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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class QueryTrajectoryByIdRequest : RpcAcsRequest<QueryTrajectoryByIdResponse>
    {
        public QueryTrajectoryByIdRequest()
            : base("CDRS", "2020-11-01", "QueryTrajectoryById")
        {
			Method = MethodType.POST;
        }

		private string corpId;

		private string endTime;

		private string startTime;

		private List<DeviceList> deviceLists = new List<DeviceList>(){ };

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

		public List<DeviceList> DeviceLists
		{
			get
			{
				return deviceLists;
			}

			set
			{
				deviceLists = value;
				for (int i = 0; i < deviceLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"DeviceList." + (i + 1) + ".DeviceId", deviceLists[i].DeviceId);
				}
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

		public class DeviceList
		{

			private string deviceId;

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
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

        public override QueryTrajectoryByIdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTrajectoryByIdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
