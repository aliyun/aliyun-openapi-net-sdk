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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class StopInstanceRequest : RpcAcsRequest<StopInstanceResponse>
    {
        public StopInstanceRequest()
            : base("Ecs", "2014-05-26", "StopInstance", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string instanceId;

        private bool? dryRun;

        private string resourceOwnerAccount;

        private bool? confirmStop;

        private string ownerAccount;

        private string action;

        private string stoppedMode;

        private long? ownerId;

        private bool? hibernate;

        private bool? forceStop;

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

        public string InstanceId
        {
            get
            {
                return instanceId;
            }
            set
            {
                instanceId = value;
                DictionaryUtil.Add(QueryParameters, "InstanceId", value);
            }
        }

        public bool? DryRun
        {
            get
            {
                return dryRun;
            }
            set
            {
                dryRun = value;
                DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

        public bool? ConfirmStop
        {
            get
            {
                return confirmStop;
            }
            set
            {
                confirmStop = value;
                DictionaryUtil.Add(QueryParameters, "ConfirmStop", value.ToString());
            }
        }

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

        public string StoppedMode
        {
            get
            {
                return stoppedMode;
            }
            set
            {
                stoppedMode = value;
                DictionaryUtil.Add(QueryParameters, "StoppedMode", value);
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

        public bool? Hibernate
        {
            get
            {
                return hibernate;
            }
            set
            {
                hibernate = value;
                DictionaryUtil.Add(QueryParameters, "Hibernate", value.ToString());
            }
        }

        public bool? ForceStop
        {
            get
            {
                return forceStop;
            }
            set
            {
                forceStop = value;
                DictionaryUtil.Add(QueryParameters, "ForceStop", value.ToString());
            }
        }

        public override StopInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return StopInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}