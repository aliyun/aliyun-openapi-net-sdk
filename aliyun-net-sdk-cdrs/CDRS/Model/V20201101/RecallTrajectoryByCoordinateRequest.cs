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
    public class RecallTrajectoryByCoordinateRequest : RpcAcsRequest<RecallTrajectoryByCoordinateResponse>
    {
        public RecallTrajectoryByCoordinateRequest()
            : base("CDRS", "2020-11-01", "RecallTrajectoryByCoordinate")
        {
			Method = MethodType.POST;
        }

		private string corpId;

		private List<PointList> pointLists = new List<PointList>(){ };

		private string endTime;

		private int? deltaDistance;

		private string startTime;

		private List<string> outputIdTypeLists = new List<string>(){ };

		private int? deltaTime;

		private int? outputIdCount;

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

		public List<PointList> PointLists
		{
			get
			{
				return pointLists;
			}

			set
			{
				pointLists = value;
				for (int i = 0; i < pointLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"PointList." + (i + 1) + ".Latitude", pointLists[i].Latitude);
					DictionaryUtil.Add(BodyParameters,"PointList." + (i + 1) + ".Longitude", pointLists[i].Longitude);
				}
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

		public List<string> OutputIdTypeLists
		{
			get
			{
				return outputIdTypeLists;
			}

			set
			{
				outputIdTypeLists = value;
				for (int i = 0; i < outputIdTypeLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"OutputIdTypeList." + (i + 1) , outputIdTypeLists[i]);
				}
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

		public int? OutputIdCount
		{
			get
			{
				return outputIdCount;
			}
			set	
			{
				outputIdCount = value;
				DictionaryUtil.Add(BodyParameters, "OutputIdCount", value.ToString());
			}
		}

		public class PointList
		{

			private float? latitude;

			private float? longitude;

			public float? Latitude
			{
				get
				{
					return latitude;
				}
				set	
				{
					latitude = value;
				}
			}

			public float? Longitude
			{
				get
				{
					return longitude;
				}
				set	
				{
					longitude = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecallTrajectoryByCoordinateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecallTrajectoryByCoordinateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
