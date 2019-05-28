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

using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Reader
{
    public class XmlReaderTest
    {
        [Fact]
        public void Read()
        {
            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Endpoints><Endpoint>Text<Name>name</Name></Endpoint><Endpoint namke=\"xmlexample\"><![CDATA[XmlExample]]></Endpoint><Endpoint name=\"ap-southeast-1\"><RegionIds><RegionId>ap-southeast-1</RegionId></RegionIds><Products><Product><ProductName>CS</ProductName><DomainName>cs.aliyuncs.com</DomainName></Product><Product><ProductName>Risk</ProductName><DomainName>risk-cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>COS</ProductName><DomainName>cos.aliyuncs.com</DomainName></Product><Product><ProductName>Ess</ProductName><DomainName>ess.aliyuncs.com</DomainName></Product><Product><ProductName>Billing</ProductName><DomainName>billing.aliyuncs.com</DomainName></Product><Product><ProductName>Dqs</ProductName><DomainName>dqs.aliyuncs.com</DomainName></Product><Product><ProductName>Dds</ProductName><DomainName>mongodb.aliyuncs.com</DomainName></Product><Product><ProductName>Alidns</ProductName><DomainName>alidns.aliyuncs.com</DomainName></Product><Product><ProductName>Sms</ProductName><DomainName>sms.aliyuncs.com</DomainName></Product><Product><ProductName>Drds</ProductName><DomainName>drds.aliyuncs.com</DomainName></Product><Product><ProductName>Dts</ProductName><DomainName>dts.aliyuncs.com</DomainName></Product><Product><ProductName>Kms</ProductName><DomainName>kms.ap-southeast-1.aliyuncs.com</DomainName></Product><Product><ProductName>Location</ProductName><DomainName>location.aliyuncs.com</DomainName></Product><Product><ProductName>Msg</ProductName><DomainName>msg-inner.aliyuncs.com</DomainName></Product><Product><ProductName>ChargingService</ProductName><DomainName>chargingservice.aliyuncs.com</DomainName></Product><Product><ProductName>R-kvstore</ProductName><DomainName>r-kvstore-cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Alert</ProductName><DomainName>alert.aliyuncs.com</DomainName></Product><Product><ProductName>Msc</ProductName><DomainName>msc-inner.aliyuncs.com</DomainName></Product><Product><ProductName>HighDDos</ProductName><DomainName>yd-highddos-cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Yundun</ProductName><DomainName>yundun-cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Ubsms-inner</ProductName><DomainName>ubsms-inner.aliyuncs.com</DomainName></Product><Product><ProductName>Ocs</ProductName><DomainName>m-kvstore.aliyuncs.com</DomainName></Product><Product><ProductName>Dm</ProductName><DomainName>dm.aliyuncs.com</DomainName></Product><Product><ProductName>Green</ProductName><DomainName>green.aliyuncs.com</DomainName></Product><Product><ProductName>Commondriver</ProductName><DomainName>common.driver.aliyuncs.com</DomainName></Product><Product><ProductName>oceanbase</ProductName><DomainName>oceanbase.aliyuncs.com</DomainName></Product><Product><ProductName>Workorder</ProductName><DomainName>workorder.aliyuncs.com</DomainName></Product><Product><ProductName>Yundunhsm</ProductName><DomainName>yundunhsm.aliyuncs.com</DomainName></Product><Product><ProductName>Iot</ProductName><DomainName>iot.ap-southeast-1.aliyuncs.com</DomainName></Product><Product><ProductName>HPC</ProductName><DomainName>hpc.aliyuncs.com</DomainName></Product><Product><ProductName>jaq</ProductName><DomainName>jaq.aliyuncs.com</DomainName></Product><Product><ProductName>Oms</ProductName><DomainName>oms.aliyuncs.com</DomainName></Product><Product><ProductName>live</ProductName><DomainName>live.aliyuncs.com</DomainName></Product><Product><ProductName>Ecs</ProductName><DomainName>ecs-cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>M-kvstore</ProductName><DomainName>m-kvstore.aliyuncs.com</DomainName></Product><Product><ProductName>Vpc</ProductName><DomainName>vpc.aliyuncs.com</DomainName></Product><Product><ProductName>BatchCompute</ProductName><DomainName>batchCompute.aliyuncs.com</DomainName></Product><Product><ProductName>AMS</ProductName><DomainName>ams.aliyuncs.com</DomainName></Product><Product><ProductName>ROS</ProductName><DomainName>ros.aliyuncs.com</DomainName></Product><Product><ProductName>PTS</ProductName><DomainName>pts.aliyuncs.com</DomainName></Product><Product><ProductName>Qualitycheck</ProductName><DomainName>qualitycheck.aliyuncs.com</DomainName></Product><Product><ProductName>Bss</ProductName><DomainName>bss.aliyuncs.com</DomainName></Product><Product><ProductName>Ubsms</ProductName><DomainName>ubsms.aliyuncs.com</DomainName></Product><Product><ProductName>Apigateway</ProductName><DomainName>apigateway.ap-southeast-1.aliyuncs.com</DomainName></Product><Product><ProductName>CloudAPI</ProductName><DomainName>apigateway.ap-southeast-1.aliyuncs.com</DomainName></Product><Product><ProductName>Sts</ProductName><DomainName>sts.aliyuncs.com</DomainName></Product><Product><ProductName>CmsSiteMonitor</ProductName><DomainName>sitemonitor.aliyuncs.com</DomainName></Product><Product><ProductName>Ace</ProductName><DomainName>ace.cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Mts</ProductName><DomainName>mts.ap-southeast-1.aliyuncs.com</DomainName></Product><Product><ProductName>CF</ProductName><DomainName>cf.aliyuncs.com</DomainName></Product><Product><ProductName>Crm</ProductName><DomainName>crm-cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Location-inner</ProductName><DomainName>location-inner.aliyuncs.com</DomainName></Product><Product><ProductName>Aas</ProductName><DomainName>aas.aliyuncs.com</DomainName></Product><Product><ProductName>Emr</ProductName><DomainName>emr.aliyuncs.com</DomainName></Product><Product><ProductName>Httpdns</ProductName><DomainName>httpdns-api.aliyuncs.com</DomainName></Product><Product><ProductName>Drc</ProductName><DomainName>drc.aliyuncs.com</DomainName></Product><Product><ProductName>Push</ProductName><DomainName>cloudpush.aliyuncs.com</DomainName></Product><Product><ProductName>Cms</ProductName><DomainName>metrics.cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Slb</ProductName><DomainName>slb.aliyuncs.com</DomainName></Product><Product><ProductName>YundunDdos</ProductName><DomainName>inner-yundun-ddos.cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Domain</ProductName><DomainName>domain.aliyuncs.com</DomainName></Product><Product><ProductName>Ots</ProductName><DomainName>ots-pop.aliyuncs.com</DomainName></Product><Product><ProductName>Cdn</ProductName><DomainName>cdn.aliyuncs.com</DomainName></Product><Product><ProductName>Ram</ProductName><DomainName>ram.aliyuncs.com</DomainName></Product><Product><ProductName>Sales</ProductName><DomainName>sales.cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Rds</ProductName><DomainName>rds.aliyuncs.com</DomainName></Product><Product><ProductName>OssAdmin</ProductName><DomainName>oss-admin.aliyuncs.com</DomainName></Product><Product><ProductName>Ons</ProductName><DomainName>ons.aliyuncs.com</DomainName></Product><Product><ProductName>Oss</ProductName><DomainName>oss-ap-southeast-1.aliyuncs.com</DomainName></Product></Products></Endpoint><Endpoint name=\"eu-central-1\"><RegionIds><RegionId>eu-central-1</RegionId></RegionIds><Products><Product><ProductName>Rds</ProductName><DomainName>rds.eu-central-1.aliyuncs.com</DomainName></Product><Product><ProductName>Ecs</ProductName><DomainName>ecs.eu-central-1.aliyuncs.com</DomainName></Product><Product><ProductName>Vpc</ProductName><DomainName>vpc.eu-central-1.aliyuncs.com</DomainName></Product><Product><ProductName>Kms</ProductName><DomainName>kms.eu-central-1.aliyuncs.com</DomainName></Product><Product><ProductName>Cms</ProductName><DomainName>metrics.cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Slb</ProductName><DomainName>slb.eu-central-1.aliyuncs.com</DomainName></Product></Products></Endpoint><Endpoint name=\"cn-zhangjiakou\"><RegionIds><RegionId>cn-zhangjiakou</RegionId></RegionIds><Products><Product><ProductName>Rds</ProductName><DomainName>rds.cn-zhangjiakou.aliyuncs.com</DomainName></Product><Product><ProductName>Ecs</ProductName><DomainName>ecs.cn-zhangjiakou.aliyuncs.com</DomainName></Product><Product><ProductName>Vpc</ProductName><DomainName>vpc.cn-zhangjiakou.aliyuncs.com</DomainName></Product><Product><ProductName>Cms</ProductName><DomainName>metrics.cn-hangzhou.aliyuncs.com</DomainName></Product><Product><ProductName>Slb</ProductName><DomainName>slb.cn-zhangjiakou.aliyuncs.com</DomainName></Product></Products></Endpoint></Endpoints>";

            var xmlReader = new XmlReader();
            var result = xmlReader.Read(xml, "ap-southeast-1");
            var context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal("cn-zhangjiakou", context.StringValue("ap-southeast-1[4].RegionIds.RegionId"));
        }

        [Fact]
        public void ReadForHideArrayItem()
        {
            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Endpoints><Endpoint name=\"ch-hangzhou\"><RegionIds><RegionId>cn-hangzhou-1</RegionId></RegionIds></Endpoint></Endpoints>";
            var xmlReader = new XmlReader();
            var result = xmlReader.ReadForHideArrayItem(xml, "endpoint");
            var context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal("cn-hangzhou-1", context.StringValue("endpoint.Endpoint.RegionIds[0]"));
        }
    }
}
