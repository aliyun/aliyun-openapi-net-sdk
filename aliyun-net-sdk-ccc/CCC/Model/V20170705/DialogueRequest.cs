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
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class DialogueRequest : RpcAcsRequest<DialogueResponse>
    {
        public DialogueRequest()
            : base("CCC", "2017-07-05", "Dialogue", "ccc", "openAPI")
        {
        }

        private string callId;

        private string callingNumber;

        private string instanceId;

        private string calledNumber;

        private string actionKey;

        private string actionParams;

        private string callType;

        private string scenarioId;

        private string taskId;

        private string utterance;

        public string CallId
        {
            get
            {
                return callId;
            }
            set
            {
                callId = value;
                DictionaryUtil.Add(QueryParameters, "CallId", value);
            }
        }

        public string CallingNumber
        {
            get
            {
                return callingNumber;
            }
            set
            {
                callingNumber = value;
                DictionaryUtil.Add(QueryParameters, "CallingNumber", value);
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

        public string CalledNumber
        {
            get
            {
                return calledNumber;
            }
            set
            {
                calledNumber = value;
                DictionaryUtil.Add(QueryParameters, "CalledNumber", value);
            }
        }

        public string ActionKey
        {
            get
            {
                return actionKey;
            }
            set
            {
                actionKey = value;
                DictionaryUtil.Add(QueryParameters, "ActionKey", value);
            }
        }

        public string ActionParams
        {
            get
            {
                return actionParams;
            }
            set
            {
                actionParams = value;
                DictionaryUtil.Add(QueryParameters, "ActionParams", value);
            }
        }

        public string CallType
        {
            get
            {
                return callType;
            }
            set
            {
                callType = value;
                DictionaryUtil.Add(QueryParameters, "CallType", value);
            }
        }

        public string ScenarioId
        {
            get
            {
                return scenarioId;
            }
            set
            {
                scenarioId = value;
                DictionaryUtil.Add(QueryParameters, "ScenarioId", value);
            }
        }

        public string TaskId
        {
            get
            {
                return taskId;
            }
            set
            {
                taskId = value;
                DictionaryUtil.Add(QueryParameters, "TaskId", value);
            }
        }

        public string Utterance
        {
            get
            {
                return utterance;
            }
            set
            {
                utterance = value;
                DictionaryUtil.Add(QueryParameters, "Utterance", value);
            }
        }

        public override bool CheckShowJsonItemName()
        {
            return false;
        }

        public override DialogueResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DialogueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}