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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceTDEResponseUnmarshaller
    {
        public static DescribeDBInstanceTDEResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDBInstanceTDEResponse describeDBInstanceTDEResponse = new DescribeDBInstanceTDEResponse();

            describeDBInstanceTDEResponse.HttpResponse = context.HttpResponse;
            describeDBInstanceTDEResponse.RequestId = context.StringValue("DescribeDBInstanceTDE.RequestId");
            describeDBInstanceTDEResponse.TDEStatus = context.StringValue("DescribeDBInstanceTDE.TDEStatus");

            List<DescribeDBInstanceTDEResponse.DescribeDBInstanceTDE_Database> describeDBInstanceTDEResponse_databases = new List<DescribeDBInstanceTDEResponse.DescribeDBInstanceTDE_Database>();
            for (int i = 0; i < context.Length("DescribeDBInstanceTDE.Databases.Length"); i++)
            {
                DescribeDBInstanceTDEResponse.DescribeDBInstanceTDE_Database database = new DescribeDBInstanceTDEResponse.DescribeDBInstanceTDE_Database();
                database.DBName = context.StringValue("DescribeDBInstanceTDE.Databases[" + i + "].DBName");
                database.TDEStatus = context.StringValue("DescribeDBInstanceTDE.Databases[" + i + "].TDEStatus");

                describeDBInstanceTDEResponse_databases.Add(database);
            }
            describeDBInstanceTDEResponse.Databases = describeDBInstanceTDEResponse_databases;

            return describeDBInstanceTDEResponse;
        }
    }
}