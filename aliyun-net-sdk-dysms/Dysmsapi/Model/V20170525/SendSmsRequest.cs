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
using Aliyun.Acs.Dysmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dysmsapi.Model.V20170525
{
    public class SendSmsRequest : RpcAcsRequest<SendSmsResponse>
    {
        public SendSmsRequest()
            : base("Dysmsapi", "2017-05-25", "SendSms")
        {
            base.Method = new MethodType?(MethodType.POST);
        }


        public override SendSmsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendSmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }

        private long? ownerId;

        private string resourceOwnerAccount;

        private long? resourceOwnerId;

        private string phoneNumbers;
        private string signName;
        private string templateCode;
        private string templateParam;
        private string outId;

        public long? OwnerId
        {
            get
            {
                return this.ownerId;
            }
            set
            {
                this.ownerId = value;
                DictionaryUtil.Add<string>(base.QueryParameters, "OwnerId", value.ToString());
            }
        }

        public string ResourceOwnerAccount
        {
            get
            {
                return this.resourceOwnerAccount;
            }
            set
            {
                this.resourceOwnerAccount = value;
                DictionaryUtil.Add<string>(base.QueryParameters, "ResourceOwnerAccount", value);
            }
        }

        public long? ResourceOwnerId
        {
            get
            {
                return this.resourceOwnerId;
            }
            set
            {
                this.resourceOwnerId = value;
                DictionaryUtil.Add<string>(base.QueryParameters, "ResourceOwnerId", value.ToString());
            }
        }

        public string PhoneNumbers
        {
            get
            {
                return this.phoneNumbers;
            }
            set
            {
                this.phoneNumbers = value;
                DictionaryUtil.Add<string>(base.QueryParameters, "PhoneNumbers", value);
            }
        }

        public string SignName
        {
            get
            {
                return this.signName;
            }
            set
            {
                this.signName = value;
                DictionaryUtil.Add<string>(base.QueryParameters, "SignName", value);
            }
        }

        public string TemplateCode
        {
            get
            {
                return this.templateCode;
            }
            set
            {
                this.templateCode = value;
                DictionaryUtil.Add<string>(base.QueryParameters, "TemplateCode", value);
            }
        }

        public string TemplateParam
        {
            get
            {
                return this.templateParam;
            }
            set
            {
                this.templateParam = value;
                DictionaryUtil.Add<string>(base.QueryParameters, "TemplateParam", value);
            }
        }

        public string OutId
        {
            get
            {
                return this.outId;
            }
            set
            {
                this.outId = value;
                DictionaryUtil.Add<string>(base.QueryParameters, "OutId", value);
            }
        }
    }
}
