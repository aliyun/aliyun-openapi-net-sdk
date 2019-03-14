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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class MetastoreDescribeDatabaseResponseUnmarshaller
    {
        public static MetastoreDescribeDatabaseResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreDescribeDatabaseResponse metastoreDescribeDatabaseResponse = new MetastoreDescribeDatabaseResponse();

			metastoreDescribeDatabaseResponse.HttpResponse = context.HttpResponse;
			metastoreDescribeDatabaseResponse.RequestId = context.StringValue("MetastoreDescribeDatabase.RequestId");
			metastoreDescribeDatabaseResponse.DbName = context.StringValue("MetastoreDescribeDatabase.DbName");
			metastoreDescribeDatabaseResponse.Description = context.StringValue("MetastoreDescribeDatabase.Description");
			metastoreDescribeDatabaseResponse.LocationUri = context.StringValue("MetastoreDescribeDatabase.LocationUri");

			MetastoreDescribeDatabaseResponse.MetastoreDescribeDatabase_Database database = new MetastoreDescribeDatabaseResponse.MetastoreDescribeDatabase_Database();
			database.Id = context.StringValue("MetastoreDescribeDatabase.Database.Id");
			database.ClusterBizId = context.StringValue("MetastoreDescribeDatabase.Database.ClusterBizId");
			database.ClusterName = context.StringValue("MetastoreDescribeDatabase.Database.ClusterName");
			database.DatabaseName = context.StringValue("MetastoreDescribeDatabase.Database.DatabaseName");
			database.DatabaseType = context.StringValue("MetastoreDescribeDatabase.Database.DatabaseType");
			database.Owner = context.StringValue("MetastoreDescribeDatabase.Database.Owner");
			database.OwnerType = context.StringValue("MetastoreDescribeDatabase.Database.OwnerType");
			database.Location = context.StringValue("MetastoreDescribeDatabase.Database.Location");
			database.Status = context.StringValue("MetastoreDescribeDatabase.Database.Status");
			database.DatabaseParameters = context.StringValue("MetastoreDescribeDatabase.Database.DatabaseParameters");
			database.GmtCreate = context.LongValue("MetastoreDescribeDatabase.Database.GmtCreate");
			database.GmtModified = context.LongValue("MetastoreDescribeDatabase.Database.GmtModified");
			database.DataSourceId = context.StringValue("MetastoreDescribeDatabase.Database.DataSourceId");
			database.DataSourceType = context.StringValue("MetastoreDescribeDatabase.Database.DataSourceType");
			database.LocationType = context.StringValue("MetastoreDescribeDatabase.Database.LocationType");
			database.DatabaseComment = context.StringValue("MetastoreDescribeDatabase.Database.DatabaseComment");
			database.ProjectId = context.StringValue("MetastoreDescribeDatabase.Database.ProjectId");
			database.ProjectName = context.StringValue("MetastoreDescribeDatabase.Database.ProjectName");
			metastoreDescribeDatabaseResponse.Database = database;

			List<MetastoreDescribeDatabaseResponse.MetastoreDescribeDatabase_Parameter> metastoreDescribeDatabaseResponse_parameters = new List<MetastoreDescribeDatabaseResponse.MetastoreDescribeDatabase_Parameter>();
			for (int i = 0; i < context.Length("MetastoreDescribeDatabase.Parameters.Length"); i++) {
				MetastoreDescribeDatabaseResponse.MetastoreDescribeDatabase_Parameter parameter = new MetastoreDescribeDatabaseResponse.MetastoreDescribeDatabase_Parameter();
				parameter.Key = context.StringValue("MetastoreDescribeDatabase.Parameters["+ i +"].Key");
				parameter._Value = context.StringValue("MetastoreDescribeDatabase.Parameters["+ i +"].Value");

				metastoreDescribeDatabaseResponse_parameters.Add(parameter);
			}
			metastoreDescribeDatabaseResponse.Parameters = metastoreDescribeDatabaseResponse_parameters;
        
			return metastoreDescribeDatabaseResponse;
        }
    }
}
