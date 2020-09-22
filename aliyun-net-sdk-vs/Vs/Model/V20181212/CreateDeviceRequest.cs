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
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class CreateDeviceRequest : RpcAcsRequest<CreateDeviceResponse>
    {
        public CreateDeviceRequest()
            : base("vs", "2018-12-12", "CreateDevice", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string gbId;

		private string latitude;

		private string description;

		private string type;

		private bool? autoStart;

		private string parentId;

		private string password;

		private string vendor;

		private string alarmMethod;

		private string directoryId;

		private string longitude;

		private string groupId;

		private string ip;

		private long? ownerId;

		private string _params;

		private string url;

		private long? port;

		private string name;

		private long? posInterval;

		private string dsn;

		private string username;

		private bool? autoPos;

		public string GbId
		{
			get
			{
				return gbId;
			}
			set	
			{
				gbId = value;
				DictionaryUtil.Add(QueryParameters, "GbId", value);
			}
		}

		public string Latitude
		{
			get
			{
				return latitude;
			}
			set	
			{
				latitude = value;
				DictionaryUtil.Add(QueryParameters, "Latitude", value);
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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public bool? AutoStart
		{
			get
			{
				return autoStart;
			}
			set	
			{
				autoStart = value;
				DictionaryUtil.Add(QueryParameters, "AutoStart", value.ToString());
			}
		}

		public string ParentId
		{
			get
			{
				return parentId;
			}
			set	
			{
				parentId = value;
				DictionaryUtil.Add(QueryParameters, "ParentId", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public string Vendor
		{
			get
			{
				return vendor;
			}
			set	
			{
				vendor = value;
				DictionaryUtil.Add(QueryParameters, "Vendor", value);
			}
		}

		public string AlarmMethod
		{
			get
			{
				return alarmMethod;
			}
			set	
			{
				alarmMethod = value;
				DictionaryUtil.Add(QueryParameters, "AlarmMethod", value);
			}
		}

		public string DirectoryId
		{
			get
			{
				return directoryId;
			}
			set	
			{
				directoryId = value;
				DictionaryUtil.Add(QueryParameters, "DirectoryId", value);
			}
		}

		public string Longitude
		{
			get
			{
				return longitude;
			}
			set	
			{
				longitude = value;
				DictionaryUtil.Add(QueryParameters, "Longitude", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
				DictionaryUtil.Add(QueryParameters, "Params", value);
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
				DictionaryUtil.Add(QueryParameters, "Url", value);
			}
		}

		public long? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public long? PosInterval
		{
			get
			{
				return posInterval;
			}
			set	
			{
				posInterval = value;
				DictionaryUtil.Add(QueryParameters, "PosInterval", value.ToString());
			}
		}

		public string Dsn
		{
			get
			{
				return dsn;
			}
			set	
			{
				dsn = value;
				DictionaryUtil.Add(QueryParameters, "Dsn", value);
			}
		}

		public string Username
		{
			get
			{
				return username;
			}
			set	
			{
				username = value;
				DictionaryUtil.Add(QueryParameters, "Username", value);
			}
		}

		public bool? AutoPos
		{
			get
			{
				return autoPos;
			}
			set	
			{
				autoPos = value;
				DictionaryUtil.Add(QueryParameters, "AutoPos", value.ToString());
			}
		}

        public override CreateDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
