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
using Aliyun.Acs.PaiFeatureStore;
using Aliyun.Acs.PaiFeatureStore.Transform;
using Aliyun.Acs.PaiFeatureStore.Transform.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
    public class ExportModelFeatureTrainingSetTableRequest : RoaAcsRequest<ExportModelFeatureTrainingSetTableResponse>
    {
        public ExportModelFeatureTrainingSetTableRequest()
            : base("PaiFeatureStore", "2023-06-21", "ExportModelFeatureTrainingSetTable")
        {
			UriPattern = "/api/v1/instances/[InstanceId]/modelfeatures/[ModelFeatureId]/action/exporttrainingsettable";
			Method = MethodType.POST;
        }

		private string modelFeatureId;

		private string body;

		private string instanceId;

		public string ModelFeatureId
		{
			get
			{
				return modelFeatureId;
			}
			set	
			{
				modelFeatureId = value;
				DictionaryUtil.Add(PathParameters, "ModelFeatureId", value);
			}
		}

		public string Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
				DictionaryUtil.Add(BodyParameters, "body", value);
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
				DictionaryUtil.Add(PathParameters, "InstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExportModelFeatureTrainingSetTableResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExportModelFeatureTrainingSetTableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
