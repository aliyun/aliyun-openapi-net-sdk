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
    public class CreateEdgeDriverVersionRequest : RpcAcsRequest<CreateEdgeDriverVersionResponse>
    {
        public CreateEdgeDriverVersionRequest()
            : base("Iot", "2018-01-20", "CreateEdgeDriverVersion", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string configCheckRule;

		private string argument;

		private string edgeVersion;

		private string description;

		private string driverId;

		private string iotInstanceId;

		private string containerConfig;

		private string driverVersion;

		private string driverConfig;

		private string sourceConfig;

		public string ConfigCheckRule
		{
			get
			{
				return configCheckRule;
			}
			set	
			{
				configCheckRule = value;
				DictionaryUtil.Add(QueryParameters, "ConfigCheckRule", value);
			}
		}

		public string Argument
		{
			get
			{
				return argument;
			}
			set	
			{
				argument = value;
				DictionaryUtil.Add(QueryParameters, "Argument", value);
			}
		}

		public string EdgeVersion
		{
			get
			{
				return edgeVersion;
			}
			set	
			{
				edgeVersion = value;
				DictionaryUtil.Add(QueryParameters, "EdgeVersion", value);
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

		public string DriverId
		{
			get
			{
				return driverId;
			}
			set	
			{
				driverId = value;
				DictionaryUtil.Add(QueryParameters, "DriverId", value);
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

		public string ContainerConfig
		{
			get
			{
				return containerConfig;
			}
			set	
			{
				containerConfig = value;
				DictionaryUtil.Add(QueryParameters, "ContainerConfig", value);
			}
		}

		public string DriverVersion
		{
			get
			{
				return driverVersion;
			}
			set	
			{
				driverVersion = value;
				DictionaryUtil.Add(QueryParameters, "DriverVersion", value);
			}
		}

		public string DriverConfig
		{
			get
			{
				return driverConfig;
			}
			set	
			{
				driverConfig = value;
				DictionaryUtil.Add(QueryParameters, "DriverConfig", value);
			}
		}

		public string SourceConfig
		{
			get
			{
				return sourceConfig;
			}
			set	
			{
				sourceConfig = value;
				DictionaryUtil.Add(QueryParameters, "SourceConfig", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateEdgeDriverVersionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateEdgeDriverVersionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
