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
using Aliyun.Acs.viapi_regen.Transform;
using Aliyun.Acs.viapi_regen.Transform.V20211119;

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
    public class UpdateTrainTaskRequest : RpcAcsRequest<UpdateTrainTaskResponse>
    {
        public UpdateTrainTaskRequest()
            : base("viapi-regen", "2021-11-19", "UpdateTrainTask", "selflearning", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.viapi_regen.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.viapi_regen.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private string trainMode;

		private long? id;

		private string datasetIds;

		private long? preTrainTaskId;

		private bool? preTrainTaskFlag;

		private string advancedParameters;

		private string name;

		private string labelIds;

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "TrainMode")]
		public string TrainMode
		{
			get
			{
				return trainMode;
			}
			set	
			{
				trainMode = value;
				DictionaryUtil.Add(BodyParameters, "TrainMode", value);
			}
		}

		[JsonProperty(PropertyName = "Id")]
		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(BodyParameters, "Id", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DatasetIds")]
		public string DatasetIds
		{
			get
			{
				return datasetIds;
			}
			set	
			{
				datasetIds = value;
				DictionaryUtil.Add(BodyParameters, "DatasetIds", value);
			}
		}

		[JsonProperty(PropertyName = "PreTrainTaskId")]
		public long? PreTrainTaskId
		{
			get
			{
				return preTrainTaskId;
			}
			set	
			{
				preTrainTaskId = value;
				DictionaryUtil.Add(BodyParameters, "PreTrainTaskId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PreTrainTaskFlag")]
		public bool? PreTrainTaskFlag
		{
			get
			{
				return preTrainTaskFlag;
			}
			set	
			{
				preTrainTaskFlag = value;
				DictionaryUtil.Add(BodyParameters, "PreTrainTaskFlag", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AdvancedParameters")]
		public string AdvancedParameters
		{
			get
			{
				return advancedParameters;
			}
			set	
			{
				advancedParameters = value;
				DictionaryUtil.Add(BodyParameters, "AdvancedParameters", value);
			}
		}

		[JsonProperty(PropertyName = "Name")]
		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "LabelIds")]
		public string LabelIds
		{
			get
			{
				return labelIds;
			}
			set	
			{
				labelIds = value;
				DictionaryUtil.Add(BodyParameters, "LabelIds", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateTrainTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateTrainTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
