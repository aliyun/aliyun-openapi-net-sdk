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
    public class DescribeSQLDiagnosisRequest : RpcAcsRequest<DescribeSQLDiagnosisResponse>
    {
        public DescribeSQLDiagnosisRequest()
            : base("Rds", "2014-08-15", "DescribeSQLDiagnosis")
        {
        }

		private string dBInstanceId;

		private string sQLDiagId;

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

		public string SQLDiagId
		{
			get
			{
				return sQLDiagId;
			}
			set	
			{
				sQLDiagId = value;
				DictionaryUtil.Add(QueryParameters, "SQLDiagId", value);
			}
		}

        public override DescribeSQLDiagnosisResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeSQLDiagnosisResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}