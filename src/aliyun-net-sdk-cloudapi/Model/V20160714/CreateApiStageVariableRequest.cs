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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateApiStageVariableRequest : RpcAcsRequest<CreateApiStageVariableResponse>
    {
        public CreateApiStageVariableRequest()
            : base("CloudAPI", "2016-07-14", "CreateApiStageVariable")
        {
        }

		private string _groupId;

		private string _stageId;

		private string _variableName;

		private string _variableValue;

		public string GroupId
		{
			get
			{
				return _groupId;
			}
			set	
			{
				_groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string StageId
		{
			get
			{
				return _stageId;
			}
			set	
			{
				_stageId = value;
				DictionaryUtil.Add(QueryParameters, "StageId", value);
			}
		}

		public string VariableName
		{
			get
			{
				return _variableName;
			}
			set	
			{
				_variableName = value;
				DictionaryUtil.Add(QueryParameters, "VariableName", value);
			}
		}

		public string VariableValue
		{
			get
			{
				return _variableValue;
			}
			set	
			{
				_variableValue = value;
				DictionaryUtil.Add(QueryParameters, "VariableValue", value);
			}
		}

        public override CreateApiStageVariableResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateApiStageVariableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}