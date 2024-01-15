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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class StartPTDetectionRequest : RpcAcsRequest<StartPTDetectionResponse>
    {
        public StartPTDetectionRequest()
            : base("Iot", "2018-01-20", "StartPTDetection", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string powerStationUid;

		private string data;

		private int? powerPlantsNumber;

		private string iotInstanceId;

		private string algorithmInstanceUid;

		private string fileName;

		private long? dataCollectionTime;

		private int? sensitivity;

		public string PowerStationUid
		{
			get
			{
				return powerStationUid;
			}
			set	
			{
				powerStationUid = value;
				DictionaryUtil.Add(QueryParameters, "PowerStationUid", value);
			}
		}

		public string Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
				DictionaryUtil.Add(QueryParameters, "Data", value);
			}
		}

		public int? PowerPlantsNumber
		{
			get
			{
				return powerPlantsNumber;
			}
			set	
			{
				powerPlantsNumber = value;
				DictionaryUtil.Add(QueryParameters, "PowerPlantsNumber", value.ToString());
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string AlgorithmInstanceUid
		{
			get
			{
				return algorithmInstanceUid;
			}
			set	
			{
				algorithmInstanceUid = value;
				DictionaryUtil.Add(QueryParameters, "AlgorithmInstanceUid", value);
			}
		}

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
				DictionaryUtil.Add(QueryParameters, "FileName", value);
			}
		}

		public long? DataCollectionTime
		{
			get
			{
				return dataCollectionTime;
			}
			set	
			{
				dataCollectionTime = value;
				DictionaryUtil.Add(QueryParameters, "DataCollectionTime", value.ToString());
			}
		}

		public int? Sensitivity
		{
			get
			{
				return sensitivity;
			}
			set	
			{
				sensitivity = value;
				DictionaryUtil.Add(QueryParameters, "Sensitivity", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override StartPTDetectionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartPTDetectionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
