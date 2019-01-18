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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class SaveApgroupConfigRequest : RpcAcsRequest<SaveApgroupConfigResponse>
    {
        public SaveApgroupConfigRequest()
            : base("cloudwf", "2017-03-28", "SaveApgroupConfig")
        {
        }

		private string country;

		private int? logLevel;

		private string name;

		private int? echoInt;

		private int? scan;

		private string description;

		private long? id;

		private string dai;

		private string logIp;

		private string accessKeyId;

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

		public int? LogLevel
		{
			get
			{
				return logLevel;
			}
			set	
			{
				logLevel = value;
				DictionaryUtil.Add(QueryParameters, "LogLevel", value.ToString());
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

		public int? EchoInt
		{
			get
			{
				return echoInt;
			}
			set	
			{
				echoInt = value;
				DictionaryUtil.Add(QueryParameters, "EchoInt", value.ToString());
			}
		}

		public int? Scan
		{
			get
			{
				return scan;
			}
			set	
			{
				scan = value;
				DictionaryUtil.Add(QueryParameters, "Scan", value.ToString());
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

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string Dai
		{
			get
			{
				return dai;
			}
			set	
			{
				dai = value;
				DictionaryUtil.Add(QueryParameters, "Dai", value);
			}
		}

		public string LogIp
		{
			get
			{
				return logIp;
			}
			set	
			{
				logIp = value;
				DictionaryUtil.Add(QueryParameters, "LogIp", value);
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

        public override SaveApgroupConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveApgroupConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}