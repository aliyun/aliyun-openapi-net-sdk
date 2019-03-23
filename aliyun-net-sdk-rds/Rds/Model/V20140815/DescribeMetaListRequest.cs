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
    public class DescribeMetaListRequest : RpcAcsRequest<DescribeMetaListResponse>
    {
        public DescribeMetaListRequest()
            : base("Rds", "2014-08-15", "DescribeMetaList", "rds", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string restoreTime;

        private string resourceOwnerAccount;

        private string clientToken;

        private string pattern;

        private string backupSetID;

        private long? ownerId;

        private string accessKeyId;

        private string getDbName;

        private string restoreType;

        private string pageSize;

        private string action;

        private string dBInstanceId;

        private string pageIndex;

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

        public string RestoreTime
        {
            get
            {
                return restoreTime;
            }
            set
            {
                restoreTime = value;
                DictionaryUtil.Add(QueryParameters, "RestoreTime", value);
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

        public string ClientToken
        {
            get
            {
                return clientToken;
            }
            set
            {
                clientToken = value;
                DictionaryUtil.Add(QueryParameters, "ClientToken", value);
            }
        }

        public string Pattern
        {
            get
            {
                return pattern;
            }
            set
            {
                pattern = value;
                DictionaryUtil.Add(QueryParameters, "Pattern", value);
            }
        }

        public string BackupSetID
        {
            get
            {
                return backupSetID;
            }
            set
            {
                backupSetID = value;
                DictionaryUtil.Add(QueryParameters, "BackupSetID", value);
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

        public string GetDbName
        {
            get
            {
                return getDbName;
            }
            set
            {
                getDbName = value;
                DictionaryUtil.Add(QueryParameters, "GetDbName", value);
            }
        }

        public string RestoreType
        {
            get
            {
                return restoreType;
            }
            set
            {
                restoreType = value;
                DictionaryUtil.Add(QueryParameters, "RestoreType", value);
            }
        }

        public string PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = value;
                DictionaryUtil.Add(QueryParameters, "PageSize", value);
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

        public string PageIndex
        {
            get
            {
                return pageIndex;
            }
            set
            {
                pageIndex = value;
                DictionaryUtil.Add(QueryParameters, "PageIndex", value);
            }
        }

        public override DescribeMetaListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeMetaListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}