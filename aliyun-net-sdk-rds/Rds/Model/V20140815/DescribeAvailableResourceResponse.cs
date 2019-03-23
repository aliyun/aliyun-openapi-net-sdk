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
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeAvailableResourceResponse : AcsResponse
    {

        private string requestId;

        private List<DescribeAvailableResource_AvailableZone> availableZones;

        public string RequestId
        {
            get
            {
                return requestId;
            }
            set
            {
                requestId = value;
            }
        }

        public List<DescribeAvailableResource_AvailableZone> AvailableZones
        {
            get
            {
                return availableZones;
            }
            set
            {
                availableZones = value;
            }
        }

        public class DescribeAvailableResource_AvailableZone
        {

            private string regionId;

            private string zoneId;

            private string status;

            private string networkTypes;

            private List<DescribeAvailableResource_SupportedEngines> supportedEngine;

            public string RegionId
            {
                get
                {
                    return regionId;
                }
                set
                {
                    regionId = value;
                }
            }

            public string ZoneId
            {
                get
                {
                    return zoneId;
                }
                set
                {
                    zoneId = value;
                }
            }

            public string Status
            {
                get
                {
                    return status;
                }
                set
                {
                    status = value;
                }
            }

            public string NetworkTypes
            {
                get
                {
                    return networkTypes;
                }
                set
                {
                    networkTypes = value;
                }
            }

            public List<DescribeAvailableResource_SupportedEngines> SupportedEngine
            {
                get
                {
                    return supportedEngine;
                }
                set
                {
                    supportedEngine = value;
                }
            }

            public class DescribeAvailableResource_SupportedEngines
            {

                private string engine;

                private List<DescribeAvailableResource_SupportedEngineVersions> supportedEngineVersion;

                public string Engine
                {
                    get
                    {
                        return engine;
                    }
                    set
                    {
                        engine = value;
                    }
                }

                public List<DescribeAvailableResource_SupportedEngineVersions> SupportedEngineVersion
                {
                    get
                    {
                        return supportedEngineVersion;
                    }
                    set
                    {
                        supportedEngineVersion = value;
                    }
                }

                public class DescribeAvailableResource_SupportedEngineVersions
                {

                    private string version;

                    private List<DescribeAvailableResource_SupportedCategorys> supportedCategory;

                    public string Version
                    {
                        get
                        {
                            return version;
                        }
                        set
                        {
                            version = value;
                        }
                    }

                    public List<DescribeAvailableResource_SupportedCategorys> SupportedCategory
                    {
                        get
                        {
                            return supportedCategory;
                        }
                        set
                        {
                            supportedCategory = value;
                        }
                    }

                    public class DescribeAvailableResource_SupportedCategorys
                    {

                        private string category;

                        private List<DescribeAvailableResource_SupportedStorageTypes> supportedStorageType;

                        public string Category
                        {
                            get
                            {
                                return category;
                            }
                            set
                            {
                                category = value;
                            }
                        }

                        public List<DescribeAvailableResource_SupportedStorageTypes> SupportedStorageType
                        {
                            get
                            {
                                return supportedStorageType;
                            }
                            set
                            {
                                supportedStorageType = value;
                            }
                        }

                        public class DescribeAvailableResource_SupportedStorageTypes
                        {

                            private string storageType;

                            private List<DescribeAvailableResource_AvailableResources> availableResource;

                            public string StorageType
                            {
                                get
                                {
                                    return storageType;
                                }
                                set
                                {
                                    storageType = value;
                                }
                            }

                            public List<DescribeAvailableResource_AvailableResources> AvailableResource
                            {
                                get
                                {
                                    return availableResource;
                                }
                                set
                                {
                                    availableResource = value;
                                }
                            }

                            public class DescribeAvailableResource_AvailableResources
                            {

                                private string dBInstanceClass;

                                private string storageRange;

                                public string DBInstanceClass
                                {
                                    get
                                    {
                                        return dBInstanceClass;
                                    }
                                    set
                                    {
                                        dBInstanceClass = value;
                                    }
                                }

                                public string StorageRange
                                {
                                    get
                                    {
                                        return storageRange;
                                    }
                                    set
                                    {
                                        storageRange = value;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}