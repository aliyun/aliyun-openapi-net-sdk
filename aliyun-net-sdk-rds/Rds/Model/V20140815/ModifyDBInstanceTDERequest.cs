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
using Aliyun.Acs.Rds;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyDBInstanceTDERequest : RpcAcsRequest<ModifyDBInstanceTDEResponse>
    {
        public ModifyDBInstanceTDERequest()
            : base("Rds", "2014-08-15", "ModifyDBInstanceTDE")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string certificate;

		private string privateKey;

		private string passWord;

		private string dBInstanceId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private bool? isRotate;

		private string encryptionKey;

		private long? ownerId;

		private string dBName;

		private string roleArn;

		private string tDEStatus;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Certificate")]
		public string Certificate
		{
			get
			{
				return certificate;
			}
			set	
			{
				certificate = value;
				DictionaryUtil.Add(QueryParameters, "Certificate", value);
			}
		}

		[JsonProperty(PropertyName = "PrivateKey")]
		public string PrivateKey
		{
			get
			{
				return privateKey;
			}
			set	
			{
				privateKey = value;
				DictionaryUtil.Add(QueryParameters, "PrivateKey", value);
			}
		}

		[JsonProperty(PropertyName = "PassWord")]
		public string PassWord
		{
			get
			{
				return passWord;
			}
			set	
			{
				passWord = value;
				DictionaryUtil.Add(QueryParameters, "PassWord", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerAccount")]
		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "IsRotate")]
		public bool? IsRotate
		{
			get
			{
				return isRotate;
			}
			set	
			{
				isRotate = value;
				DictionaryUtil.Add(QueryParameters, "IsRotate", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EncryptionKey")]
		public string EncryptionKey
		{
			get
			{
				return encryptionKey;
			}
			set	
			{
				encryptionKey = value;
				DictionaryUtil.Add(QueryParameters, "EncryptionKey", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "DBName")]
		public string DBName
		{
			get
			{
				return dBName;
			}
			set	
			{
				dBName = value;
				DictionaryUtil.Add(QueryParameters, "DBName", value);
			}
		}

		[JsonProperty(PropertyName = "RoleArn")]
		public string RoleArn
		{
			get
			{
				return roleArn;
			}
			set	
			{
				roleArn = value;
				DictionaryUtil.Add(QueryParameters, "RoleArn", value);
			}
		}

		[JsonProperty(PropertyName = "TDEStatus")]
		public string TDEStatus
		{
			get
			{
				return tDEStatus;
			}
			set	
			{
				tDEStatus = value;
				DictionaryUtil.Add(QueryParameters, "TDEStatus", value);
			}
		}

        public override ModifyDBInstanceTDEResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBInstanceTDEResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
