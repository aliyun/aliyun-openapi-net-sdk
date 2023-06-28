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
using Aliyun.Acs.Linkvisual.Transform;
using Aliyun.Acs.Linkvisual.Transform.V20180120;

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
    public class CreateLocalFileUploadJobRequest : RpcAcsRequest<CreateLocalFileUploadJobResponse>
    {
        public CreateLocalFileUploadJobRequest()
            : base("Linkvisual", "2018-01-20", "CreateLocalFileUploadJob", "Linkvisual", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotInstanceId;

		private List<int?> timeSlots = new List<int?>(){ };

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

		public List<int?> TimeSlots
		{
			get
			{
				return timeSlots;
			}

			set
			{
				timeSlots = value;
				if(timeSlots != null)
				{
					for (int depth1 = 0; depth1 < timeSlots.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TimeSlot." + (depth1 + 1), timeSlots[depth1]);
						DictionaryUtil.Add(QueryParameters,"TimeSlot." + (depth1 + 1), timeSlots[depth1]);
						DictionaryUtil.Add(QueryParameters,"TimeSlot." + (depth1 + 1), timeSlots[depth1]);
						DictionaryUtil.Add(QueryParameters,"TimeSlot." + (depth1 + 1), timeSlots[depth1]);
						DictionaryUtil.Add(QueryParameters,"TimeSlot." + (depth1 + 1), timeSlots[depth1]);
					}
				}
			}
		}

		public class TimeSlot
		{

			private int? endTime;

			private int? startTime;

			private string productKey;

			private string deviceName;

			private string iotId;

			public int? EndTime
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

			public int? StartTime
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

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public string DeviceName
			{
				get
				{
					return deviceName;
				}
				set	
				{
					deviceName = value;
				}
			}

			public string IotId
			{
				get
				{
					return iotId;
				}
				set	
				{
					iotId = value;
				}
			}
		}

        public override CreateLocalFileUploadJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLocalFileUploadJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
