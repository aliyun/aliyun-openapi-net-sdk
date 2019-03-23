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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateMigrateTaskForSQLServerRequest : RpcAcsRequest<CreateMigrateTaskForSQLServerResponse>
    {
        public CreateMigrateTaskForSQLServerRequest()
            : base("Rds", "2014-08-15", "CreateMigrateTaskForSQLServer", "rds", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string taskType;

        private string dBName;

        private string resourceOwnerAccount;

        private string isOnlineDB;

        private string action;

        private string dBInstanceId;

        private long? ownerId;

        private string accessKeyId;

        private string oSSUrls;

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

        public string TaskType
        {
            get
            {
                return taskType;
            }
            set
            {
                taskType = value;
                DictionaryUtil.Add(QueryParameters, "TaskType", value);
            }
        }

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

        public string IsOnlineDB
        {
            get
            {
                return isOnlineDB;
            }
            set
            {
                isOnlineDB = value;
                DictionaryUtil.Add(QueryParameters, "IsOnlineDB", value);
            }
        }

        public string Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
                DictionaryUtil.Add(QueryParameters, "Action", value);
            }
        }

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

        public string OSSUrls
        {
            get
            {
                return oSSUrls;
            }
            set
            {
                oSSUrls = value;
                DictionaryUtil.Add(QueryParameters, "OSSUrls", value);
            }
        }

        public override CreateMigrateTaskForSQLServerResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateMigrateTaskForSQLServerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}